using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            //SortedDictionary<int, string> d = new SortedDictionary<int, string>();
            d.Add(1, "A");
            d.Add(5,"C");
            d.Add(3, "D");
            d[1] = "Soumya";

            foreach(var kvp in d)
            {
                Console.WriteLine($"key = {kvp.Key} and value = {kvp.Value}");
            }
            //Console.WriteLine(d[2]);
            Console.WriteLine(d.ElementAt(0));
            Console.WriteLine(d.Keys.ElementAt(0));
            Console.WriteLine(d.Values.ElementAt(1));
          

            foreach(var key in d.Keys)
            {
                Console.WriteLine(d[key]);
            }
            Console.WriteLine(d.ContainsValue("F"));
            Console.ReadLine();
        }
    }
}
