using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._13com.factory
{
    class Divide : ICalculate //in factory pattern, every class must have an interface
    {
        public void Calculate (double a, double b)
        {
            Console.WriteLine("a/b is {0}", a / b);
        }
    }
}
