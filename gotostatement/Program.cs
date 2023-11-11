using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotostatement
{
    class Program
    {
        static void Main(string[] args)
        {

        start:
            System.Console.WriteLine("Entering ......");

            System.Console.WriteLine("Enter the age");
            int age = System.Convert.ToInt32(System.Console.ReadLine());

            if (age < 18)
            {
                goto start;
            }
            else
            {
                System.Console.WriteLine("Perfect");
            }

            Console.ReadLine();
        }
    }
}
