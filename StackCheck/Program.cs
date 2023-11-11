using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(2);
            st.Push("Soumya");
            st.Push(5);
            foreach(var x in st)
            {
                Console.WriteLine(x);
            }
            var y = st.Pop();
            var z = st.Peek();
            Console.WriteLine("y="+y);
            Console.WriteLine("z=" + z);
            foreach (var x in st)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(st.Contains("Soumya"));
        }
    }
}
