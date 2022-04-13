using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Singleton
    {
        private static Singleton singleton; //it is a static object because a static method can only call a static object, not a normal one
        //singleton pattern way to access a class so that only one object(multiple copies of it can exist) can be created

        private static Singleton instance;
        private Singleton(){

        }

        //we make sure that there is only one singleton object by using this method and creating it via this.
        public static Singleton GetInstance() //we make it static so that we can call the method without calling the class first(as we cant use constructor)
        {
            if(singleton == null)
            {
                singleton = new Singleton();
            }

            return singleton;
        }
        //the way to do it with get
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }

        }
    }
}

// we use singleton for logging, device drivers, printers or things like registry settings, where we just need to have only one of it's kind to prevent errors.
// to prevent stuff like inconsistent results, incorrect programming behavior
