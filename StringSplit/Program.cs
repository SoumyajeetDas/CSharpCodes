using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Hello Wrorld,Go:Away";
            //string[] arr = str.Split(new char[] { ' ', ',', ':' });
            //foreach (var x in arr)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine(string.Format("{0:0.0#}", 24));
            //DateTime dt = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine(dt);
            int[] arr = { 1, 2, 3, 4, 5 };
            IList<int> il = (from s in arr select s).ToList<int>();

            IList<int> li1 = il;

            foreach(var x in li1)
            {
                Console.WriteLine(x);
            }


            IEnumerable<int> iEn= (from s in arr select s).ToList<int>();
            foreach (var x in iEn)
            {
                Console.WriteLine(x);
            }

            //IQueryable<int> iq = (from s in arr select s);
            //foreach (var x in iq)
            //{
            //    Console.WriteLine(x);
            //}



            Console.ReadKey();
        }
    }
}
