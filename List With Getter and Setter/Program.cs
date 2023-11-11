using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_With_Getter_and_Setter { 
    class A
    {
        public List<int> li  = new List<int>();
        public void func()
        {
            li.Add(2);
            li.Add(3);
            foreach(var x in li)
            {
                Console.WriteLine(x); 
            }
        }
    }

    class Program
    {
        public List<int> li { get; set; } = new List<int>();
        static void Main(string[] args)
        {

            A a = new A();
            a.func();
            Console.ReadKey();
        }
    }
}
