using MVCApp.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace MVCApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        [Authorize(Roles = "User, Admin")]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [Authorize(Roles = "User, Admin")]
        public ActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        [Authorize(Roles = "User, Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employees List";

            var data = LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var item in data)
            {
                employees.Add(new EmployeeModel
                {
                    EmployeeId = item.EmployeeId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    EmailAddress = item.EmailAddress
                });
            }

            return View(employees);
        }

        [Authorize(Roles = "User, Admin")]
        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sign Up";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateEmployee(employeeModel.EmployeeId, employeeModel.FirstName, employeeModel.LastName, employeeModel.EmailAddress);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}