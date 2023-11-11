using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandInterface
{
    interface A
    {
        void Print();
    }

    class B
    {
        public void Print()
        {
            Console.WriteLine("In function of B");
        }
    }
    class Program : B,A
    {
        /*
        public void Print()
        {
            Console.WriteLine("Due to Abstraction");
        }
        */
        static void Main(string[] args)
        {

            B b = new B();
            b.Print();
            A a = new Program();
            a.Print();
            Console.ReadLine();

        }
    }
}
