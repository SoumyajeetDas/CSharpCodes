using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new LinkedList<int>();

            i.AddLast(2);
            i.AddFirst(1);
            i.AddFirst(3);
            foreach(var j in i)
            {
                Console.WriteLine(j);
            }
            //Console.WriteLine(i.First.Value);
            LinkedListNode<int> node = i.Find(1);
            Console.WriteLine("Node ="+node.Value);
            i.AddAfter(node, 20);
      
            foreach (var j in i)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
