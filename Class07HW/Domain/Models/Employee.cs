using HWDomain.Enumerations;

namespace HWDomain.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }
        public Employee[] Employees { get; set; }
        public Employee() { }
 
        public Employee(string firstName, string lastName, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Salary: {GetSalary()}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
