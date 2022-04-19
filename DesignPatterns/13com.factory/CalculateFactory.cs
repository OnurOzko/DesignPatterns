using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._13com.factory
{
    public class CalculateFactory
    {
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
