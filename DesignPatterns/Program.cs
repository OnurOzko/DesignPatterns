using DesignPatterns._13com.factory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton singleton1 = new Singleton(); //is inaccessable due to the fact that we made constructor private
            //Singleton singleton2 = new Singleton(); //is inaccessable due to the fact that we made constructor private

            Singleton singleton1 = Singleton.GetInstance(); //we managed to call the method without creating a class object because our method is a static one
            Singleton singleton2 = Singleton.GetInstance(); //totally same object, thanks to our GetInstanceMethod

            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode()); //same hash code so they are same object (without get)

            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            Console.WriteLine(instance1.GetHashCode());
            Console.WriteLine(instance2.GetHashCode()); //same hash code so they are same object (with get)


            //----------------------------Inheritence, Interface etc. --------------------------------//

            A aobj = new A(); //on how to create objects from class constructor(basic stuff anyway)
            B bobj = new B(); //on how to create objects from class constructor(basic stuff anyway)
            int z = 10;

            //Superclass object = new Subclass(); is possible
            A obj1 = new B(); 
            //just like a int example on top. 
            //Subclass object = new Superclass(); is not possible
            //B ojbc2 = new A();


            obj1.MethodA();
            //obj1.MethodB(); object is a B object but can only act like an A object, just like on int z example, so we cant call a method which isn't written in class A. so it gives error.

            //to access Method B with obj1 we can do:
            //((B)obj1).MethodB;
            //(obj1 as B).MethodB; which overrides the A part of our method with B, so it would be same as B obj1 = new B();

            //----------------------------Inheritence, Interface Part2 with Employee and IEmail etc. --------------------------------//

            IEmail email = new OutlookEmail();
            Employee obj = new Employee(100, "Alex", email); //ID and Name can be only set once while creating the class 
            //obj.empID = 100;     //can not be accessed or changed due to protecton levels, in other word, values are private
            //obj.empName = "Alex";
            obj.salary = 10000; //easily accessable
            obj.NotifyEmployee();

            email = new WebServiceEmail();
            Employee obj3 = new Employee(200, "Lynda", email);
            obj3.NotifyEmployee();

            //---------------------------Factory Pattern---------------------------------//

            Console.WriteLine("Enter first number");
            string input = Console.ReadLine();
            double num1, num2;
            bool result = Double.TryParse(input, out num1);
            if (!result)
            {
                Console.WriteLine("Please enter a number: ");
                return;
            }
            Console.WriteLine("Enter second number: ");
            result = Double.TryParse(Console.ReadLine(), out num2);
            if (!result)
            {
                Console.WriteLine("Please enter a number: ");
                return;
            }
            Console.WriteLine("Enter Add, Substract or Divide");
            CalculateFactory factory = new CalculateFactory();
            ICalculate objFac = factory.GetCalculation(Console.ReadLine());
            objFac.Calculate(num1, num2);


            //-----------------------------//

        }
    }
}
