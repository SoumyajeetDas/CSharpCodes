using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankInformation
{
    
    class Program
    {
        static void Main(string[] args)
        {

           
            String s = "";
            Console.Write("Enter Account No : ");
            int acc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Account Holder Name : ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Bank Name : ");
            string bank = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter Bank Balance:");
            int bal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            s += acc + "," + name + "," + bank + "," + bal;
            using (FileStream file = new FileStream(@"output.csv", FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {

                    writer.WriteLine(s);
                    Console.WriteLine("Bank Information  written to file successfully.");
                    Console.WriteLine("The file \"output.csv\" should contain the bank information");
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
