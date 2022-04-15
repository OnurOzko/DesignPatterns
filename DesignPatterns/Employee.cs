using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Employee
    {
        public int empID;
        public string empName;
        public double salary;
        public int grade;
        public string company;

        public Employee(int empID, string empName) //we use constructors to set, minimum needed values to create an employee object 
        {
            this.empID = empID;
            this.empName = empName;
        }

    }

}
