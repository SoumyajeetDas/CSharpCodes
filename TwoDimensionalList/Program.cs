using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> data = new List<List<int>>();
            //List<int> item = new List<int>();
            //item.Add(2);
            //item.Add(3);
            //item.Add(4);
            //item.Add(5);
            //data.Add(item);

            //List<int> item1 = new List<int>();
            //item1.Add(6);
            //item1.Add(7);
            //item1.Add(8);
            //item1.Add(9);
            //data.Add(item1);

            //foreach(var list in data)
            //{
            //    foreach(var lists in list)
            //    {
            //        Console.Write(lists+" ");
            //    }
            //    Console.WriteLine();
            //}



            for (int i=0;i<3;i++)
            {
                
                List<int> item = new List<int>();
                item.Add(2);
                item.Add(3);
                item.Add(4);
                item.Add(5);
                data.Add(item);
            }

            //foreach (var list in data)
            //{
            //    foreach (var lists in list)
            //    {
            //        Console.Write(lists + " ");
            //    }
            //    Console.WriteLine();
            //}

            int[][] arr = new int[data.Count][];

            for (int i = 0; i < data.Count; i++)
            {
                arr[i] = data[i].ToArray();
            }

            
            for (int i = 0; i < arr.Length; i++)
            {
               
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }

            //int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //int x = arr1.GetLength(0);
            //for(int i=0;i<arr1.GetLength(0);i++)
            //{
            //    int y = arr1.GetLength(1);
            //    for(int j=0;j<arr1.GetLength(1);j++)
            //    {

            //    }
            //}

            //int[] arr = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(arr.GetLength(1));
        }


        
        
    }
}
