using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPropagatorCheck
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Person> Children { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student() { Name = "Peter", Email = "peter@abc.com" };
            Student student = new Student();
            Console.WriteLine(student.Name?.ToUpper() ?? "Name is empty");
            Console.WriteLine(student.Email?.ToUpper() ?? "Email is empty");

            //var customer = new Person()
            //{
            //    Children = new List<Person>()
            //    {
            //        new Person()
            //        {
            //            Id=1
            //        }
            //    }
            //};
            //var customer = new Person();
            //Console.Write("First child: ");
            //Console.WriteLine(customer.Children?.FirstOrDefault()?.Name ?? "-");
        }
    }
}
