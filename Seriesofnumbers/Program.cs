using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seriesofnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter a series");
            string x = Console.ReadLine();
            var x1 = x.Split(',');
            int[] n = new int[x1.Length];
            foreach (string p in x1)
            {
                n[i] = int.Parse(p);
                i++;
            }
            int max = 0;
            foreach (var a in n)
            {
                if (max < a)
                    max = a;
            }

            Console.WriteLine("Max value is " + max);

            var a1 = "1, 2 3 4,5";
            var a2 = a1.Split(',', ' ');
            foreach(var k in a2)
            {
                Console.WriteLine(k);
            }
            //List<int> li = new List<int>();
            //Console.WriteLine("Source Array");
            //foreach(var b in n)
            //{
            //    Console.Write(b+" ");
            //}
            //Console.WriteLine();
            //li.AddRange(n);
            //if(li.Count==0 || li.Count<5)
            //    Console.WriteLine("Invalid List");
            //else
            //{
            //    li.Sort();
            //    Console.WriteLine(li[0]);
            //}
            //var arr1 = new int[x1.Length+1];
            //n.CopyTo(arr1, 1);
            //Console.WriteLine("Copied Array");
            //foreach (var b in arr1)
            //{
            //    Console.Write(b + " ");
            //}
            //Console.WriteLine(Array.IndexOf(n,10));
            //Console.WriteLine(DateTime.Today);
            //Console.WriteLine(DateTime.Now);

            //var k = DateTime.Now;
            //var k1 = k.AddYears(1);
            //Console.WriteLine(k);
        }
    }
}
