using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPractise
{
    /*
    static class A
    {
        public static void print()
        {
            Console.WriteLine("In static class");
            //Console.Line();
        }
    }
    */
    
    class B
    {
        static B()
        {
            Console.WriteLine("In static Constructor B");
        }
        public static void printing()
        {
            Console.WriteLine("In static class of B");
        }
        public void p()
        {
            Console.WriteLine("Normal");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //A.print();

            B b = new B();
            b.p();
           B.printing();
            B a = new B();
            a.p();
            B.printing();
            Console.ReadLine();
            

        }
    }
}
