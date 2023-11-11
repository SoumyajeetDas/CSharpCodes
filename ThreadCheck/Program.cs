using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadCheck
{
    class Program
    {
        static void Test1()
        {
            for(int i = 0;i<100;i++)
            {
                Console.WriteLine("Test 1 : "+i);
            }
            
            //Thread t2 = new Thread(Test2);
            //t2.Start();
            //t2.Join();
            Console.WriteLine("Thread 1 ended");

        }

        static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i==50)
                {
                    Console.WriteLine("Thread 2 gone to sleep");
                    Thread.Sleep(15000);
                    Console.WriteLine("Thread 2 woke up");
                    
                }
                Console.WriteLine("Test 2 : " + i);
            }
            Console.WriteLine("Thread 2 ended");
        }

        static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test 3 : " + i);
            }
            Console.WriteLine("Thread 3 ended");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");

            Thread t1 = new Thread(Test1);

            Thread t2 = new Thread(Test2);
            
            Thread t3 = new Thread(Test3);

            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("Main thread ended");
        }
    }
}
