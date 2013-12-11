using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using ConsoleApplication3.Behavioural_Patterns;
using ConsoleApplication3.BrainTeasers;

namespace ConsoleApplication3
{
    class Program
    {
        //int hh = 0;
        static void Main(string[] args)
        {
            object[] array = new String[10];
            // The following statement produces a run-time exception. 
            //array[0] = 10;
            //Action<string> aname = SetMyName;
            //aname("hj");
            M m = new M();
            //N n = new N();
            m.Print();
           // n.Print();
               
            Func<string, int> chk = delegate(string x) { return x.Length; };
            //Console.WriteLine( chk("jko"));
           // SetMyName(th,9);
            //B b1 = new B();
            //B hi = new B();
            //hi.Get();
            //b1.Get();
            //A a = new A();
            //a.Get();
            //A v = new B();
            //v.Get();
            //ArrayList n = new ArrayList();
            //Creational_Patterns.Singleton.SingletonV.DoWork();

            //Creational_Patterns.Singleton.SingletonV.DoWork();
            //Approver manager = new Manager();
            //Approver sbuhead = new Sbuhead();
            //manager.Successor = sbuhead;
            //var request = new Request { RequestID = 1 };
            //var acType=new ActionType{ ActionName="approved"};
            //var acRequest = new RequestAction { RequestID = 1, action = acType };
            //manager.ProcessRequest(acRequest);
            Console.ReadLine();
        }
        public static int  chko(string oo)
        {
            return oo.Length;
        }
        public static void SetMyName<T>(Func<int> fnc,T t)
        {
            Console.WriteLine("sanjay" + fnc()); 
        }
        
        public class A
        {
            public virtual  void Get()
            {
                Console.WriteLine("hel");
                
            }
           
        }
        public class B : A
        {
            public sealed override void Get()
            {
               
                Console.WriteLine("greens");
            }
            
        }
        public class C : B
        {
            public  void Get()
            {
                Console.WriteLine("c got it");
            }
            
        }
        
        
    }
    

    



   
}
