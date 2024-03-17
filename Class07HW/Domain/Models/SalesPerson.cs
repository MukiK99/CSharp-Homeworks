using HWDomain.Enumerations;
namespace HWDomain.Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Sales;
            Salary = 500;
        }
        public double AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue += number;
            return SuccessSaleRevenue;
        }
        public double GetSuccessRevenue()
        {
            return SuccessSaleRevenue;
        }

        public override double GetSalary()
        {
            double finalSalary = Salary;

            if (SuccessSaleRevenue < 2000)
            {
                finalSalary += 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue < 5000)
            {
                finalSalary += 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                finalSalary += 1500;
            }
            return finalSalary;
        }
    }
}
