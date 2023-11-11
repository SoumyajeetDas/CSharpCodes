using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayParam
{
    
    class Program
    {
        static void Printing(params int []a)
        {
            foreach (int i in a)
            {
                Console.Write(i+" ");
            }
        }
        static void Main(string[] args)
        {

            int []a = new int[5];
            Printing(2, 3, 4, 5, 6, 7, 8);
            Console.ReadLine();

        }
    }
}
