using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    public class ShiftSupervisor : Employee
    {
        // Property to store the annual salary
        public decimal AnnualSalary { get; set; }

        // Property to store the annual production bonus
        public decimal AnnualBonus { get; set; }

        // Default constructor
        // Sets the AnnualSalary and AnnualBonus to default values
        public ShiftSupervisor()
        {
            AnnualSalary = 0.0m;
            AnnualBonus = 0.0m;
        }

        // Parameterized constructor
        // Allows creating a ShiftSupervisor object with specified values
        // Includes base class parameters (name, empNum) and specific parameters (annualSalary, annualBonus)
        public ShiftSupervisor(string name, int empNum, decimal annualSalary, decimal annualBonus) : base(name, empNum)
        {
            AnnualSalary = annualSalary;
            AnnualBonus = annualBonus;
        }
    }
}
