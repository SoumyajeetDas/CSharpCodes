using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadCheck
{
    class LockThreading
    {
        public static object _object = new object();
        public void Display()
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Trying to enter the lock thread Id : "+ thread.ManagedThreadId);
            lock(_object)
            {
                
                Console.WriteLine("Thread ID : "+ thread.ManagedThreadId);
                Thread.Sleep(5000);
                
            }
            Console.WriteLine("Released from lock thread Id : " + thread.ManagedThreadId);
        
            

        }
        static void Main(string[] args)
        {
            LockThreading lt = new LockThreading();
            Thread t1 = new Thread(lt.Display);
            Thread t2 = new Thread(lt.Display);
            t1.Start();
            t2.Start();
        }
    }
}
