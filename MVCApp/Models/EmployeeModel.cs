using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid EmployeeId.")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give us your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give us your last name.")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to give us your email address.")]
        public string EmailAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "The email and confirm email must match.")]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "You need to provide a long enough password.")]
        [Required(ErrorMessage = "You must have a password.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirm password must match.")]
        public string ConfirmPassword { get; set; }
    }
}