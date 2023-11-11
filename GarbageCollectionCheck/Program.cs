using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionCheck
{
    class Foo : IDisposable
    {
       
        private int x;
        public Foo()
        {
            Console.WriteLine("Default Constructor");
        }
        public Foo(int x)
        {
            this.x = x;
            Console.WriteLine("Parametirized Constructor = "+x);
        }

        public void Dispose()
        {
            Console.WriteLine("Clean up the unmaneged resources");
            GC.SuppressFinalize(this);
        }

        ~Foo()
        {
            Console.WriteLine("Destructor Called" );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (Foo f = new Foo())
            {

            }
            //Foo f1, f2, f3, f4;
            //f1 = new Foo(1);
            //f2 = new Foo(2);
            //Console.WriteLine("Generation of f1 "+GC.GetGeneration(f1));
            //Console.WriteLine("Generation of f2 "+GC.GetGeneration(f2));
            //f2 = null;
            GC.Collect();
            //f3 = new Foo(3);
            //Console.WriteLine("Generation of f1 " + GC.GetGeneration(f1));
            //Console.WriteLine("Generation of f3 " + GC.GetGeneration(f3));
            //f3 = null;

            //f4 = new Foo(4);
            //GC.Collect();

            //Console.WriteLine("Generation of f1 " + GC.GetGeneration(f1));
            //Console.WriteLine("Generation of f4 " + GC.GetGeneration(f4));




        }
    }
}
