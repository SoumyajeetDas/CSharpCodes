using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortInterface
{
    class Student : IComparable<Student>
    {
        //private int marks, age, roll;
        //private string name;



        public string name
        {
            set;
            get;
        }
        public int age
        {
            set;
            get;
        }
        public int roll
        {
            set;
            get;
        }
        public int marks
        {
            set;
            get;
        }


        public int CompareTo(Student other)
        {
            return (this.name.CompareTo(other.name));
        }
    }

    class Mycompare : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return (x.name.CompareTo(y.name));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> li = new List<Student>();

            li.Add(new Student { name = "Soumya", age = 22, roll = 1, marks = 40 });
            li.Add(new Student { name = "Dippya", age = 70, roll = 3, marks = 90 });
            li.Add(new Student { name = "Sounak", age = 45, roll = 2, marks = 95 });


            foreach (var s in li)
            {
                Console.WriteLine($"Name = {s.name} Age = {s.age} Roll = {s.roll} Marks = {s.marks}");
            }
            li.Sort(new Mycompare());

            Console.WriteLine("After Sort");

            foreach (var s in li)
            {
                Console.WriteLine($"Name = {s.name} Age = {s.age} Roll = {s.roll} Marks = {s.marks}");
            }
            Console.ReadLine();
        }
    }
}
