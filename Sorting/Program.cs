using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter the array");

            for(int i=0;i<5;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Enter the element to search");

            int n = Convert.ToInt32(Console.ReadLine());

            int pos = Array.BinarySearch(arr, 1,3,n);

            if(pos>=0)
            {
                Console.WriteLine($"{n} is in position {pos}");
            }

            else
            {
                Console.WriteLine("Element not Found");
            }

            Console.ReadLine();


        }
    }
}
