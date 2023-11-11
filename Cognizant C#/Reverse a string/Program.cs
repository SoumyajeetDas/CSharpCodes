using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a string");
            String str = Console.ReadLine();
            
            String[] sarr = str.Split(' ');
            String s = "";
            for (int i = sarr.Length-1; i >= 0; i--)
            {
                s += sarr[i] + " ";
            }
            Console.WriteLine(s);
            Console.ReadLine();
            
            
        }
    }
}
