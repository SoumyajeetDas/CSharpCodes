using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Add");
            hs.Add("Soumya");
            hs.Add("Subsract");
            hs.Add("Dippya");
            hs.Add("Rohan");
            hs.Add("Sourav");
            foreach (var i in hs)
            {
                Console.WriteLine(i + " ");
            }
            
            Console.ReadLine();
        }
    }
}
