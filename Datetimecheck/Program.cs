using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetimecheck
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;


            DateTime bday = new DateTime(1998 , 06 , 19);
            Console.WriteLine(today.Year);
            Console.WriteLine(bday.Year);
            int age = today.Year - bday.Year;
            Console.WriteLine(age);

            if(bday>today.AddYears(-age))
            {
                age--;
            }
            Console.WriteLine(age);


            Console.ReadLine();

        }
    }
}
