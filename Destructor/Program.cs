using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class A
    {
        int i = 0;
        public A()
        {
            Console.WriteLine("Entered in Constructor A");
        }

        ~A()
        {
            Console.WriteLine("Entered in Destructor A"+(i++));
            Console.ReadLine();
        }
    }

    class B
    {
        public B()
        {
            Console.WriteLine("Entered in Constructor B");
        }

        ~B()
        {
            Console.WriteLine("Entered in Destructor B");

            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            A b = new A();
            Console.ReadLine();
        }
    }
}
