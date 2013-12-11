using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3.BrainTeasers
{
    //represents how u fill the stack and over flow it by wrongle putting two classes as members of each other and 
    //then the instantiation on one class leads to member within that class to call and instantiate other and they
    //happen to keep instantiating ininitely.
    public class N
    {
        public M m = new M();//This initiates infinite loopin and addressing and will be terminated by process 
        public void Print()
        {
            Console.WriteLine("N called");
            
            m.Print();//even this line will never be reached
            m.n.m.n.m.Print();
        }
    }
    public class M 
    {
        public N n = new N();//This initiates infinite loopin and addressing and will be terminated by process
        public void Print()//never get called
        {
            Console.WriteLine("M called");
            n.m.n.m.Print();//pattern never ends mnmnmnmnmnmnmnmnmnmnmnmnmn...so on
        }
    }
}
