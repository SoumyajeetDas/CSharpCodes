using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putaway
{
    class Program
    {
        static void Main(string[] args)
        {
            Getaway.A a = new Getaway.A();
            a.Func();
            Console.ReadLine();
        }
    }
}

namespace Getaway
{

    class A
    {
        void Func()
        {
            Console.WriteLine("You are in namespace Getaway");
        }
    }

}
