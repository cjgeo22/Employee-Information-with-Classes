using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _11_1
{
    //create productionworker class that inherits from employee class
    //meaning it includes all properties and methods of the employee class
    public class ProductionWorker : Employee
    {
        //get and set shift into int and hourlyrate into a decimal
        public int Shift { get; set; }
        public decimal HourlyRate { get; set; }

        //default class state w/ no parameters
        public ProductionWorker()
        {
            Shift = 0;
            HourlyRate = 0.0m;
        }

        //production worker constructor including employee class parameters
        public ProductionWorker(string name, int empnum,  int shift, decimal hourlyRate) : base(name, empnum)
        {
            Shift = shift;
            HourlyRate = hourlyRate;
        }

    }
}
