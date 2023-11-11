using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculate;


namespace CalculationReferencedll
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reference Calculate.dll


            calculate c = new calculate();

            Console.WriteLine(c.Add(2,3));
            Console.ReadKey();


        }
    }
}
