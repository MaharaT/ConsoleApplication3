using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3.Creational_Patterns
{
    //Single Object Exisence + Thread Safe Pattern
    public sealed class Singleton
    {
        //private static Singleton Singleton_s;//Will  Result in Locked Singleton Instance vallue cannot be null
        //Better Option is:
        private static  Singleton Singleton_s = new Singleton();//Prevents checking if null
        private Singleton()
        {

        }
        public static Singleton SingletonV
        {
            get
            {
                lock (Singleton_s)
                {
                    
                    Singleton_s = Singleton_s ?? new Singleton();//Every Time this Checking will be done when we call for singleton class
                    return Singleton_s;
                }
            }
        }
        public void DoWork()
        {
            Console.WriteLine("Method called");
        }
    }
}
