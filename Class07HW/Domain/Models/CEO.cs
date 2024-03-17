using HWDomain.Enumerations;
namespace HWDomain.Models
{
    public class CEO : Employee
    {
        Employee[] Employees {  get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO()
        {

        }
        public CEO(Employee[] employees)
        {
            Employees = employees;
        }
        public CEO(string firstName, string lastName, double salary, Role role,Employee[] employees, int shares) : base(firstName, lastName, role) 
        {
            Salary = salary;
            Employees = employees;
            Shares = shares;
            
        }

        public double AddSharesPrice(double number)
        {
            SharesPrice = number;
            return SharesPrice;
        }
        public void PrintEmployees()
        {
            int counter = 0;
            Console.WriteLine("Employees:");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{++counter}.{employee.FirstName} {employee.LastName}\n");
            }
        }
        public override double GetSalary()
        {
            Salary = Salary + (Shares * SharesPrice);
            Console.WriteLine($"The CEO salary is: {Salary}");
            return Salary;
            
        }

    }
}
