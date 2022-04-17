using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._13com.factory
{
    interface ICalculate  //FACTORY PATTERN ALWAYS STARTS BY INTERFACE, EVERY CLASS MUST HAVE AN INTERFACE ATTACHED TO IT!!
    {
        void Calculate(double num1, double num2);
    }
}
