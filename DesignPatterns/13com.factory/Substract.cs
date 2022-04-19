using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._13com.factory
{
    public class Substract : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a-b is {0}", a - b);
        }
    }
}
