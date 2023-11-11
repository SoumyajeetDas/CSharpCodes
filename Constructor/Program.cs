using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class A
    {
        /*
        public A()
        {
            Console.WriteLine("In Constructor of A");
        }
        */
        public A(int i)
        {
            Console.WriteLine("In parametirized Constructor of A");
        }
    }
    class B:A
    {
        public B(int i , int j):base(1)
        {
           
            Console.WriteLine("In Constructor of B");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {

            B b = new B(2,3);
            Console.ReadLine();

        }
    }
}
