using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibraryCheck
{
    class Program
    {
        public static void MilloinIterations()
        {
            for(int i=0; i<2000000000;i++)
            {
                Console.WriteLine($"value of count = {i}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Parallel.For(0, 2000000000, (x) =>
            {
                //MilloinIterations();
                Console.WriteLine($"value of count = {x}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            });
            
        }
    }
}
