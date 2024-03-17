using HWDomain.Enumerations;

namespace HWDomain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, Role role, double workHours, int payPerHour, Manager responsible) : base(firstName, lastName, role)
        {
          
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public string CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}
