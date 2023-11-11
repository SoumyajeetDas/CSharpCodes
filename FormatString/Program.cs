using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatString
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "";
            string items = "Items";
            s+= "0---5---10---15---20---25---30---35---40\n";
            s += string.Format("{0,-20}", items);
            s += string.Format("{0,20}", "Price");
            Console.WriteLine(s);
            float no = 23.45f;
            float no1 = 9.0f;
            Console.WriteLine(String.Format("Float={0:f},Float={1:f}",no,no1));
            Console.WriteLine(String.Format("Date = {0:t}",DateTime.Now));
            Console.WriteLine(String.Format("Date = {0:d}",DateTime.Now));
            Console.WriteLine(String.Format("Percenrtage = {0:p}",0.67));
            Console.WriteLine(String.Format("Number = {0:D}",5));

            
            Console.ReadKey();
        }
    }
}
