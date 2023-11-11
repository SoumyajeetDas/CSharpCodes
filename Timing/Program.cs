using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time in 24 hr format");
            DateTime result;



            //if (DateTime.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out result))
            //{
            //    if ((result.Hour>=00 && result.Hour<=23)&& (result.Minute >= 00 && result.Minute <= 59))
            //        Console.WriteLine("Ok");
            //    else
            //        Console.WriteLine("Invalid time");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            Console.WriteLine(Directory.GetCurrentDirectory());
        }
    }
}
