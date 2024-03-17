using HWDomain.Enumerations;
namespace HWDomain.Models
{
    public class Manager : Employee
    {
        public double Bonus { get; set; }
        public string Department { get; set; }

        public Manager(string firstName, string lastName, double salary, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Bonus = 0;
            Salary = salary;
            Role = Role.Manager;
            Department = department;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }
    }
}
