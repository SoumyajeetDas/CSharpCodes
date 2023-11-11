using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the number of pizzas bought : ");
            int pizza = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of puffs bought : ");
            int puffs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of pepsi bought : ");
            int pepsi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bill Details\n");
            Console.WriteLine("Cost of Pizzas :" + (pizza * 200));
            Console.WriteLine("Cost of Puffs :" + (puffs * 40));
            Console.WriteLine("Cost of Pepsis :" + (pepsi * 120));
            double gst = ((pizza * 200) + (puffs * 40) + (pepsi * 120)) * 0.12;
            double cess = ((pizza * 200) + (puffs * 40) + (pepsi * 120)) * 0.05;
            int total = (pizza * 200) + (puffs * 40) + (pepsi * 120);

            Console.WriteLine("GST 12% : " + gst);
            Console.WriteLine("CESS 5% : " + cess);
            Console.WriteLine("Total Price :" + total);
            Console.ReadLine();
            

            
        }
    }
}
