using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Soumya");
            al.Add(30);
            //al.Add("Soumya");
            al.Add(35);
            al[2] = 40;
            Console.WriteLine(al.Contains(30));
            //Console.WriteLine(al.BinarySearch(30));
            //Console.WriteLine(al[1]);

            IEnumerator ie = al.GetEnumerator();
            while(ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
            
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
            //al.Sort();            //foreach (var x in al)
            //{
            //    Console.WriteLine(x);
            //}

            //ArrayList aList = new ArrayList();
            //aList.Add("One");
            //aList.Add("Two");
            //aList.Add("Three");
            //aList.Add("Four");
            //aList.Add("Five");

            //IEnumerator iEn = aList.GetEnumerator();
            //while (iEn.MoveNext())
            //{
            //    Console.WriteLine(iEn.Current.ToString());
            //}


        }
    }
}
