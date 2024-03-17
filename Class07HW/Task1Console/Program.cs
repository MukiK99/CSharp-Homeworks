using HWDomain.Models;
using HWDomain.Enumerations;

Employee John = new Employee()
{
    FirstName = "John",
    LastName = "Doe",
    Role = Role.Other
};
John.PrintInfo();
Console.WriteLine("\n\n");

SalesPerson Gina = new SalesPerson("Gina", "Gardner");
Gina.AddSuccessRevenue(1000);
Gina.PrintInfo();
Gina.AddSuccessRevenue(3000);
Gina.PrintInfo();
Gina.AddSuccessRevenue(7000);
Gina.PrintInfo();
Console.WriteLine("\n\n");


Manager Murat = new Manager("Murat", "Koca", 5000, "IT");
Murat.PrintInfo();
Murat.AddBonus(2000);
Murat.PrintInfo();
double salaryWithBonus = Murat.GetSalary();
Console.WriteLine(salaryWithBonus);
Console.WriteLine("\n\n");

Contractor Shawn = new Contractor("Shawn", "Dean", Role.Other, 40, 20, Murat);
Shawn.PrintInfo();
Shawn.CurrentPosition();
Console.WriteLine($"Shawn's manager current department is: {Shawn.CurrentPosition()}");

Console.ReadLine();
