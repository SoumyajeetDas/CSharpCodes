using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchusingwhen
{
    
    class Person 
    {
        public int Pid
        {
            set;get;
        }

        public string Name
        {
            set;get;
        }

    }

    class Employee 
    {
        public int EmpId
        {
            set;get;
        }
        public string Name
        {
            set;get;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lp = new List<Person>()
            {
                new Person(){ Pid=1 , Name = "Soumyajeet" },
                new Person(){ Pid=2 , Name = "Sounak" },
                new Person(){ Pid=3 , Name = "Sehroz" }
            };

            List<Employee> lm = new List<Employee>()
            {
                new Employee() { EmpId = 1, Name="A"},
                new Employee() { EmpId = 2, Name="B"},
                new Employee() { EmpId = 3, Name="C"}
            };

            void cases(object obj)
            {
                switch (obj)
                {
                    case Person p when p.Pid == 1:
                        Console.WriteLine("Name = " + p.Name);
                        break;

                    case Employee e when e.EmpId == 2:
                        Console.WriteLine("Name = " + e.Name);
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
            
                

                foreach(var x in lp)
                {
                    cases(x);
                }

                foreach (var x in lm)
                {
                    cases(x);
                }

            
        }
    }
}
