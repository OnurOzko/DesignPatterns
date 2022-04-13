using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class A //Basic concept of inheritance , interface etc
    {
        public virtual void MethodA()
        {
            Console.WriteLine("This is Method A inside of Class A");

        }
    }

    class B : A
    {
        public override void MethodA()
        {
            Console.WriteLine("This is Method A inside of Class B");
        }
        public void MethodB()
        {
            Console.WriteLine("This is Method B inside of Class B");

        }
    }
}
