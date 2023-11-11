using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> sl = new SortedList<int,string>();
            sl.Add(3, "A");
            sl.Add(2, "B");
            sl.Add(1, "B");

            foreach(var kvp in sl)
            {
                Console.Write($"Key = {kvp.Key} and Value = {kvp.Value}\n");
            }
         
            
            Console.WriteLine(sl.Count);
            Console.ReadLine();

          

        }
    }
}
