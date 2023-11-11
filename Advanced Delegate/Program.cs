
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, decimal, double> area = (r, pi) => (float)pi * Math.Pow(r, 2);
            Console.WriteLine(area(2,3.14m));

            Action<int> output = (x) =>
            {
                if(x>2)
                    Console.WriteLine("Hi I am Soumyajeet");
                else
                    Console.WriteLine("Not Soumyajeet");
            };



            output(2);

            List<string> name = new List<string>();
            name.Add("Soumyajeet");
            name.Add("Dippya");
            name.Add("Sounak");


            Predicate<string> Lessthan7 = x => x.Length < 7;
            Console.WriteLine(Lessthan7("Shubham"));

            //foreach(var x in name)
            //{
            //    Console.WriteLine(Lessthan7(x));
            //}

            string names = name.Find(Lessthan7);
            Console.WriteLine(names) ;

            Console.WriteLine();


            var y = name.FindAll(Lessthan7);
            foreach(var x in y)
            {
                Console.WriteLine(x);
            }

            //bool names = name.Contains("Subham");
            //Console.WriteLine(names);


        }
    }
}
