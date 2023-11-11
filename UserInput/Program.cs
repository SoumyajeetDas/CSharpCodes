using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter your name");
            String s = Console.ReadLine();
            Console.WriteLine("Enter the no of candies");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(s + " " + (n+4));
            int a = (int)3.6;
            double a1 = 4;
            Console.WriteLine(a);
            
            char v;
            Console.WriteLine("Enter a character");
            bool a = Char.TryParse(Console.ReadLine(), out v);

            if(a==true)
            {
                Console.WriteLine(v);
            }
            else
            {
                Console.WriteLine("Not a character");
            }
            */

            //int a = (int)Math.Abs(-2.33);
            //Console.WriteLine(a);
            /*

            String x = "Soumya";
            Console.WriteLine(x.Length);


            string name = "Soumyajeet";
            int age = 23;

            Console.WriteLine($"The name is {name} with age of {age+5}");
            */

           string str1 = "mark";
           string str2 = "marcus";

           
    
        Console.WriteLine("str1 = '{0}'", str1);
        Console.WriteLine("str2 = '{0}'", str2);

        Console.WriteLine("After using String.Copy...");
        string str3 = String.Copy(str1);
            str3 = "Soumya";

        Console.WriteLine("str1 = '{0}'", str1);
        Console.WriteLine("str2 = '{0}'", str3);

            Console.WriteLine("After using String.Clone...");

            String str4 = (string)str1.Clone();
            str4="Soumya";
            Console.WriteLine("str1 = '{0}'", str1);
        Console.WriteLine("str2 = '{0}'", str4);

            Console.WriteLine("After using =  ...");

            string str5=str1;
            str5="Soumya";
            Console.WriteLine("str1 = '{0}'", str1);
        Console.WriteLine("str2 = '{0}'", str5);


            Console.ReadLine();
        }
    }
}
