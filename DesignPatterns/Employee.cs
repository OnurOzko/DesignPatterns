using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Employee
    {
        private int empID;
        private string empName; //we are not going to change this value after it is created, so it is private
        public double salary { get; set;} //we make them public with get and set, which means, those values can be updated anytime
        public int grade {get; set;}
        public string company = "IBM"; //this value is hard-coded to IBM as default

        public Employee(int empID, string empName) //we use constructors to set, minimum needed values to create an employee object 
        {
            this.empID = empID;
            this.empName = empName;
        }

    }

}
