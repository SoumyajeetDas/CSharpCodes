using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutCheck
{
   
    class Program
    {

        static void Func(out int val1 , out int val2)
        {
            val1 = 100;
            val2 = 200;
            val1 += 10;
            val2 += 15;
        }
        static void Main(string[] args)
        {

            int val1 = 15;
            int val2 = 17;

            Console.WriteLine($"val1 = {val1} and val2 = {val2}");

            Func(out val1, out val2);

            Console.WriteLine($"val1 = {val1} and val2 = {val2}");
            Console.ReadLine();
        }
    }
}
