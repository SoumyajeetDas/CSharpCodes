using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadCheck
{
    class LockThreadingwithMonitor
    {
        public static object _object = new object();
        public void Display()
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Trying to enter the lock thread Id : " + thread.ManagedThreadId);
            Monitor.Enter(_object);
            try
            {
                Console.WriteLine("Thread ID : " + thread.ManagedThreadId);
                Thread.Sleep(5000);
            }
            catch
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Releasing the lock for thread Id : " + thread.ManagedThreadId);
                Monitor.Exit(_object);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting the Monitor Lock");
            LockThreadingwithMonitor lt = new LockThreadingwithMonitor();
            Thread t1 = new Thread(lt.Display);
            Thread t2 = new Thread(lt.Display);
            t1.Start();
            t2.Start();
        }
    }
}
