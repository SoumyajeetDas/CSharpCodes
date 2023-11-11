using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCloning
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4 };
            //int[] arr2 = (int[])arr.Clone();
            //int []arr2 = arr;
            int[] arr2 = new int[3];
            Array.Copy(arr, 1, arr2, 0, 3);

            foreach (int i in arr2)
            {
                System.Console.Write(i + " ");
            }
           
            arr2[2] = 56;

            System.Console.WriteLine();
            foreach (int i in arr)
            {
                System.Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
