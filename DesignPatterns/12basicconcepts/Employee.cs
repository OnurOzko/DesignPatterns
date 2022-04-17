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

        IEmail email; //just creating an instance of the interface

        //tl;dr if you need an object required, add it to constructor and make it private to prevent it from getting changed(unless you need otherwise)
        //and make it public or add get, sets for those that is not necessary and can be changed often

        public Employee(int empID, string empName, IEmail email) //we use constructors to set, minimum needed values to create an employee object 
            //added e-mail to make sure that Instance has a value assigned to it, otherwise, console doesn't shows up any errors!
        {
            this.empID = empID;
            this.empName = empName;
            this.email = email;
        }

        public void NotifyEmployee()
        {
            email.sendEmail();
        }

    }

}
