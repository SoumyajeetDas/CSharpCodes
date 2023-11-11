using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //DateTime s;
            //DateTime.TryParseExact("2019-06-05", "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out s);
            //Console.WriteLine(s);


            DateTime dateTime13; // 1/1/0001 12:00:00 AM  
            bool isSuccess4 = DateTime.TryParseExact(dateString, "MM/dd/yyyy", provider, System.Globalization.DateTimeStyles.None, out dateTime13);
            Console.WriteLine(dateTime13);
            Console.ReadKey();
        }
    }
}
