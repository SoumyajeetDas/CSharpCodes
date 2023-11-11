using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringtoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = "19-1998-06";
            DateTime result;
            if(DateTime.TryParseExact(dateString, "dd-yyyy-MM", null,System.Globalization.DateTimeStyles.None,out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Cannot Convert");
            }

            //DateTime dateTime13; // 1/1/0001 12:00:00 AM  
            //bool isSuccess4 = DateTime.TryParseExact("2018/06/19", "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out dateTime13);
            //Console.WriteLine(dateTime13);
            Console.ReadKey();
        }
    }
}
