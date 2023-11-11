using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oveeriding
{
    class A
    {
        public virtual void print()
        {
            Console.WriteLine("IN A");
        }
    }

    class B : A
    {
        public override void print()
        {
            base.print();
            Console.WriteLine("IN B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            B b = new B();
            b.print();
            Console.ReadLine();
        }
    }
}
