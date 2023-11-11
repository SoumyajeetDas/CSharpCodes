using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassMethod
{
    //public class GFG<T>
    //{

    //    // private data members
    //    private T data;

    //    // using properties
    //    public T value
    //    {

    //        // using accessors
    //        get
    //        {
    //            return this.data;
    //        }
    //        set
    //        {
    //            this.data = value;
    //        }
    //    }
    //    public type display <type> ( type value)
    //    {
    //        return value;
    //    }
    //}

    class A
    {
        public void func<T, U>(T a, U b)
        {
            Console.WriteLine("a = " + a + " " + "b = " + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //GFG<int> g = new GFG<int>();
            //g.value = 10;
            //int k = g.display<int>(20);
            //Console.WriteLine(k);
            A a = new A();
            a.func<int, string>(20, "Soumya");

        }
    }
}
