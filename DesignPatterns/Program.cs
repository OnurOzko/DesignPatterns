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
            //obj1.MethodB(); object is a B object but can only act like an A object, just like on int z example, so we cant call a method which isn't written in class A 



        }
    }
}
