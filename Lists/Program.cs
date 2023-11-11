using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        private static bool isEven(int i)
        {
            return ((i % 2) == 0);
        }
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(5);
            li.Add(1);
            li.Add(6);
            li.Add(2);
            //li.Add(1);
            //li.Add(2);
            /*
            for(int i=1;i<10;i++)
            {
                li.Add(i);
            }
            */
            //foreach(int i in li)
            //{
            //    Console.Write(i + " ");
            //}

            IEnumerable<int> iEn = li ;
          

            List<int>.Enumerator em = li.GetEnumerator();
            while(em.MoveNext())
            {
                Console.WriteLine(em.Current);
            }
            //li.Remove(1);
            li.RemoveAll(i=>(i%2)==0);
            //li.Sort();
            //li.Reverse();
            //int index = li.LastIndexOf(5);
            //Console.WriteLine($"index = {index}");
            Console.WriteLine();

            foreach (int i in li)
            {
                Console.Write(i + " ");
            }


            
            
            Console.ReadLine();
        }
    }
}
