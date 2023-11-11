using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassCheck
{
    public partial class Employee
    {
        public int id
        {
            set;get;
        }
        public string name
        {
            set;get;
        }
        partial void Department();
    }

    public partial class Employee
    {
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;

        }

        public void display()
        {
            Console.WriteLine("id = "+id+" "+"name = "+name);
        }

        partial void Department()
        {
            Console.WriteLine("No department");
        }

        public void show()
        {
            Department();
        }
    }
    class PartialNew
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1,"Soumyajeet");
            e.display();
            e.show();
            

        }
    }
}
