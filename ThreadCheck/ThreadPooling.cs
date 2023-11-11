using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadCheck
{
    class ThreadPooling
    {
        public static void MethodWithThread()
        {
            for (int i = 0; i < 10; i++)
            {
                ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
                Thread thread = new Thread(obj);
                thread.Start(50);
            }
        }
        public static void MethodWithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            }
            
        }
        public static void Test(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);

        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Method with Normal Thread");
            Console.WriteLine();
            MethodWithThread();
            Console.WriteLine();

            Thread.Sleep(5000);
            Console.WriteLine("Method with  Thread Pooling ");
            Console.WriteLine();
            MethodWithThreadPool();
            Console.WriteLine();
        }
    }
}
