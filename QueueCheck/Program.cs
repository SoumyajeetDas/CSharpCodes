using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(2);
            q.Enqueue("Soumya");
            q.Enqueue(3);
            q.Enqueue(4);
            foreach(var x in q)
            {
                Console.WriteLine(x);
            }
            var a = q.Dequeue();
            Console.WriteLine("a="+a);
            foreach (var x in q)
            {
                Console.WriteLine(x);
            }

        }
    }
}
