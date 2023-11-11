
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsLinqCheck
{
    class Student
    {
        public int Id;
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){Id=1, Name="Soumyajeet"},
                new Student(){Id=2,Name="Sounak"}
            };
            var stud = students[0];

            var li = new List<String>() { "ABC", "CDE" };
            var st = li.AsEnumerable().Contains("ABC");
            //var st = students.AsEnumerable().Contains(stud);
            Console.WriteLine(st);
            Console.ReadKey();
        }
    }
}
