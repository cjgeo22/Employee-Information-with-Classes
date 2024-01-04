using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    public class Employee
    {
        //gets and sets the information into a string Name and an int EmpNum
        public string Name { get; set; }
        public int EmpNum { get; set; }

        //default class state
        //if a class object is instantiated without parameteres
        public Employee()
        {
            Name = "Unknown";
            EmpNum = 0;
        }

        //employee constructor
        //allows creating emp object with specific parameters
        public Employee(string name, int empNum)
        {
            Name = name;
            EmpNum = empNum;
        }
    }
}
