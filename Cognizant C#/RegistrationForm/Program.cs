using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name :");
            string name = Console.ReadLine();
           


            Console.Write("Enter your country :");
            int age = Convert.ToInt32(Console.ReadLine());
        


            Console.Write("Enter your age :");
            string country = Console.ReadLine();



            // Console.WriteLine("Welcome "+s+". Your age is "+age+" and you are from "+country);
            // Console.WriteLine($"Welcome {s}. Your age is {age} and you are from {country}");
            System.Console.WriteLine("Welcome {0}. Your age is {1} and you are from {2}", name, age, country);
            Console.ReadLine();

        }
    }
}
