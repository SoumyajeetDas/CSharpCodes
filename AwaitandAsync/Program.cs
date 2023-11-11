
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AwaitandAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Method();
            Method2();
            Console.WriteLine("Main Thread " + Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
        }

        public async static void Method()
        {
            
            //await Task.Run(new Action(LongTask));
            await Task.Run(()=>
            {
                test1();
            });

            //await Task.Run(new Action(Test2));
            //await Task.Run(new Action(Test3));
            Console.WriteLine("New Thread " + Thread.CurrentThread.ManagedThreadId);
        }

        public static void Method2()
        {
            Console.WriteLine("Hi Soumyajeet");
        }

        public static void test1()
        {
            Thread.Sleep(3000);
        }

        //static void Test1()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine("Test 1 : " + i);
        //    }

        //    //Thread t2 = new Thread(Test2);
        //    //t2.Start();
        //    //t2.Join();
        //    Console.WriteLine("Thread 1 ended");

        //}

        //static void Test2()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        if(i==50)
        //        {
        //            Console.WriteLine("Sleep");
        //            Thread.Sleep(5000);
        //        }
        //        Console.WriteLine("Test 2 : " + i);
        //    }
        //    Console.WriteLine("Thread 2 ended");
        //}

        //static void Test3()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine("Test 3 : " + i);
        //    }
        //    Console.WriteLine("Thread 3 ended");
        //}
    }
}
