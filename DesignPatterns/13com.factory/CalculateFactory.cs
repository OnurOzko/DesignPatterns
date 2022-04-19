using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._13com.factory
{
    public class CalculateFactory
    {
        //every method must have a class assigned to it and every class must be inherited from same super class, which also has those methods in name
        //we prevent creating unnecessary different types of class objects and just use this super class to access to any method we like to do so
        public ICalculate GetCalculation(string type) //we are just creating an instance as we cant create object of an interface
        {
            ICalculate obj = null;

            if (type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("substract"))
            {
                obj = new Substract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("We don't do that");
            }

            return obj; 
        }
    }
}
