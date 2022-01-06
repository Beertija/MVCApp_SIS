# MVCApp_SIS

Kako bi se pokrenula aplikacija, odnosno Web stranica, treba se imati Visal Studio sa ASP.NET bibliotekom instaliranom. 
Zatim prilikom prvotnog otvaranja solutiona, ako izbaci error zbog nedostatka baze, potrebno je publishati MVCDemoDB projekt kako bi se kreirala baza sa tablicom.

## U slučaju nedostatka podataka

Ukoliko se ne prenesu sadržaji baza podataka.
Unos korisnika, odnosno same registracije vrši se unutar dbo.AspNetUsers tablice. 
Kako bi se otvorila dodatna mogućnost stranice, potrebno je ručno dodati u tablicu dbo.AspNetRoles dvije uloge: Admin i User. Također, mora se i ručno dodati prava pristupa u dbo.AspNerUserRoles tablicu ID Usera i ID Prava.
Samo kao admin se može pristupiti pregledu svih "zaposlenika", forma za dodavanje novih zaposlenika dostupna je unutar pregleda svih zaposlenika.
