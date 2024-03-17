using HWDomain.Models;
using HWDomain.Enumerations;
Manager Jeremy = new Manager("Jeremy", "Kerr", 2500, "Law");
Manager Tom = new Manager("Tom", "Cann", 3000, "HR");
Contractor Jake = new Contractor("Jake", "Reeves", Role.Other, 50, 22, Jeremy);
Contractor Irene = new Contractor("Irene", "Pierce", Role.Other, 45, 20, Tom);
SalesPerson Nate = new SalesPerson("Nate", "Logan");
Employee[] Company = new Employee[]
{
  Jeremy,
  Tom,
  Nate,
  Jake,
  Irene
};
Console.WriteLine("CEO:");
CEO Murat = new CEO("Murat", "Koca",5000, Role.CEO, Company, 200);
Murat.AddSharesPrice(1000);
Murat.PrintInfo();
Murat.PrintEmployees();


Console.ReadLine();