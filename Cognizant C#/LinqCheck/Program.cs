using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCheck
{
    class Student
    {
        public string name
        {
            set; get;
        }
        public int id
        {
            set; get;
        }
        public string gender
        {
            set; get;
        }
        public Student(string name, int id, string gender)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
        }

        //public override String ToString()
        //{
        //    return "Name = " + name + "id = " + id + "Gender = " + gender;
        //}
    }

    //class Dept
    //{
    //    public int id
    //    {
    //        set;get;
    //    }
    //    public string D_Name
    //    {
    //        set;get;
    //    }
    //    public Dept(int id,string D_Name)
    //    {
    //        this.id = id;
    //        this.D_Name = D_Name;
    //    }

    //}
    //class CULWords
    //{
    //    public string LowerWord { get; set; }
    //    public string UpperWord { get; set; }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            //string []arr = { "C# Tutorials","VB.NET Tutorials","Learn C++","MVC Tutorials" ,"Java"  };
            //var x = from i in arr where i.Contains("Tutorials") select i;
            //foreach (var k in x)
            //{
            //    Console.WriteLine(k);
            //}
            //List<Student> li = new List<Student>();
            //li.Add(new Student("Soumyajeet", 4, "Male"));
            //li.Add(new Student("Dippya", 1, "Female"));
            //li.Add(new Student("Sounak", 4, "Male"));
            //li.Add(new Student("Rohan", 2, "Female"));
            //li.Add(new Student("Sourav", 5, "Male"));


            //List<Dept> d = new List<Dept>();
            //d.Add(new Dept(1, "CSE"));
            //d.Add(new Dept(2, "ETC"));
            //d.Add(new Dept(3, "ECE"));
            //d.Add(new Dept(4, "Mech"));
            //d.Add(new Dept(5, "Civil"));

            ////Join

            //var x = from s in li join de in d on s.id equals de.id where s.gender == "Male"orderby s.id,s.name select new { Student_Name = s.name, Student_Dept = de.D_Name };

            //foreach (var i in x)
            //{
            //    Console.WriteLine(i.Student_Name + "=" + i.Student_Dept);
            //}

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee {ID = 101, Name = "Preety", Gender = "Female", Salary = 60000,
            //                  Technology = new List<string>() {"C#", "Jave", "C++"} },
            //    new Employee {ID = 102, Name = "Priyanka", Gender = "Female", Salary = 50000,
            //                  Technology =new List<string>() { "WCF", "SQL Server", "C#" } },
            //    new Employee {ID = 103, Name = "Hina", Gender = "Female", Salary = 40000,
            //                  Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
            //    new Employee {ID = 104, Name = "Anurag", Gender = "Male", Salary = 450000},
            //    new Employee {ID = 105, Name = "Sambit", Gender = "Male", Salary = 550000},
            //    new Employee {ID = 106, Name = "Sushanta", Gender = "Male", Salary = 700000,
            //                 Technology =new List<string>() { "ADO.NET", "C#", "LINQ" }}
            //};
            //var result = from employee in employees
            //             where employee.Salary >= employees.Average(a=>a.Salary)
            //             select employee;

            ////var x = from emp in employees group emp by  emp.Gender  into egroup select egroup;
            //var x = from emp in employees group emp by new { emp.Name, emp.Gender } into egroup where egroup.Key.Gender=="Male" orderby egroup.Key.Name select egroup;
            //foreach (var y in result)
            //{
            //    Console.WriteLine(y.Name);
            //}

            //List<student> Students = new List<student>()
            //  {
            //     new student{id = 1, name ="ram", age = 20, standard =12},
            //     new student{id = 2, name ="zip", age = 18, standard =10},
            //     new student{id = 3, name ="any", age = 19, standard =12},
            //     new student{id = 4, name ="Ian", age = 18, standard =10},
            //     new student{id = 5, name ="john", age = 17, standard =10},
            //     new student{id = 6, name ="bob", age = 19, standard =12},
            //     new student{id = 7, name ="moni", age = 18, standard =10},
            //     new student{id = 8, name ="sri", age = 19, standard =12},
            //     new student{id = 9, name ="dummy" , age = 17, standard =10},
            //     new student{id = 10, name ="hon" , age = 17, standard =10},
            //  };
            //var res = from stu in Students group stu by new { stu.age, stu.standard } into sgroup where sgroup.Key.age>18 orderby sgroup.Key.standard  select sgroup;

            //foreach (var y in res)
            //{
            //    Console.WriteLine("Class = " + y.Key);
            //    foreach (var z in y)
            //    {
            //        Console.WriteLine("Id = " + z.id + "Name = " + z.name);
            //    }
            //}

            //string[] words = { "ManGo", "aPpLe", "BaNaNa", "StrawbeRRY", "AvOcAdO" };
            //Console.WriteLine("Using Class CULWords");
            //var ulwords = from w in words
            //              select new CULWords()
            //              {
            //                  LowerWord = w.ToLower(),
            //                  UpperWord = w.ToUpper()

            //              };
            //foreach (CULWords w in ulwords)
            //{
            //    Console.WriteLine(w.LowerWord + " " + w.UpperWord);
            //}

            List<Student> li = new List<Student>();
            li.Add(new Student("Soumyajeet", 4, "Male"));
            li.Add(new Student("Dippya", 1, "Female"));
            li.Add(new Student("Sounak", 4, "Male"));
            li.Add(new Student("Rohan", 2, "Female"));
            li.Add(new Student("Sourav", 5, "Male"));
            Console.WriteLine("By var");
         
            var query = from obj in li
                        where obj.id==1
                        select obj;

            foreach(Student stu in query)
            {
                Console.WriteLine("Name = "+stu.name+" Id = "+stu.id+" Gender = "+stu.gender);
            }
            Console.WriteLine();


            Console.WriteLine("By IEneumerable");
         
            IEnumerable<Student> ien = from obj in li
                                       where obj.id==1
                                       select obj;
            foreach (Student stu in ien)
            {
                Console.WriteLine("Name = " + stu.name + " Id = " + stu.id + " Gender = " + stu.gender);
            }
            Console.WriteLine();


            Console.WriteLine("By List");

            List<Student> li1 = (from obj in li
                                       where obj.id == 1
                                       select obj).ToList<Student>();
            foreach (Student stu in li1)
            {
                Console.WriteLine("Name = " + stu.name + " Id = " + stu.id + " Gender = " + stu.gender);
            }
            Console.WriteLine();

            Console.WriteLine("By IList");

            IList<Student> ili1 = (from obj in li
                                 where obj.id == 1
                                 select obj).ToList<Student>();
            foreach (Student stu in ili1)
            {
                Console.WriteLine("Name = " + stu.name + " Id = " + stu.id + " Gender = " + stu.gender);
            }
            Console.WriteLine();


            Console.WriteLine("By IQueryable");
            IQueryable<Student> iq = (from obj in li
                                     where obj.id == 1
                                     select obj).AsQueryable<Student>();

            foreach (Student stu in iq)
            {
                Console.WriteLine("Name = " + stu.name + " Id = " + stu.id + " Gender = " + stu.gender);
            }


            Console.WriteLine();
            Console.WriteLine("By IQueryable and Method Syntax");
            IQueryable<Student> iq1 = li.AsQueryable<Student>().Where(obj=>obj.id==1);
            foreach (Student stu in iq)
            {
                Console.WriteLine("Name = " + stu.name + " Id = " + stu.id + " Gender = " + stu.gender);
            }


            Console.WriteLine();
            Console.WriteLine("select stament using method syntax without using select command");
            var q = li.ToList<Student>();//For selecting all the column no need to write the Select() for method syntax
            foreach (Student stu in q)
            {
                Console.WriteLine("Name = " + stu.name + " Id = " + stu.id + " Gender = " + stu.gender);
            }

            Console.WriteLine();
            Console.WriteLine("select stament using method syntax with using select command");
            var q1 = li.Select(obj => obj).ToList<Student>();//For selecting all the column no need to write the Select() for method syntax
            foreach (Student stu in q)
            {
                Console.WriteLine("Name = " + stu.name + " Id = " + stu.id + " Gender = " + stu.gender);
            }

            Console.WriteLine();
            Console.WriteLine("select stament using query  syntax selecting only the id");
            var li2 = (from obj in li
                        select obj.id).ToList<int>();
            foreach (int stu in li2)
            {
                Console.WriteLine(" Id = " + stu);
            }

            Console.WriteLine();
            Console.WriteLine("select stament using method syntax selecting only the id");
            var li3 = li.Select(obj => obj.id).ToList<int>();
            foreach (int stu in li3)
            {
                Console.WriteLine(" Id = " + stu);
            }

            Console.WriteLine();
            Console.WriteLine("select stament using query syntax selecting only the id and the name with anonymous type");
            var li4 = (from obj in li
                       select new { Id = obj.id, Name = obj.name });
            foreach (var stu in li4)
            {
                Console.WriteLine(" Id = " + stu.Id + " Name = "+stu.Name);
            }

            Console.WriteLine();
            Console.WriteLine("select stament using query syntax selecting only the id and the name with Student class");
            var li5 = (from obj in li
                       select new Student(null,0,null) 
                       { 
                           id = obj.id, name = obj.name 
                       });
            foreach (var stu in li5)
            {
                Console.WriteLine(" Id = " + stu.id + " Name = " + stu.name + " Gender = "+ stu.gender);
            }

            Console.WriteLine();
            Console.WriteLine("select stament using method syntax selecting only the id and the name with anonymous type");
            var li6 = li.Select(obj => new
            {
                Id = obj.id,
                Name = obj.name
            }).ToList() ;
            foreach (var stu in li6)
            {
                Console.WriteLine(" Id = " + stu.Id + " Name = " + stu.Name);
            }


            Console.WriteLine();
            Console.WriteLine("select stament using meyhod syntax selecting only the id and the name with Student class");
            var li7 = li.Select(obj => new Student(null, 0, null)
                       {
                           id = obj.id,
                           name = obj.name
                       });
            foreach (var stu in li7)
            {
                Console.WriteLine(" Id = " + stu.id + " Name = " + stu.name + " Gender = " + stu.gender);
            }


            Console.WriteLine();
            Console.WriteLine("Using selectmany with method syntax with list of type");
            List<String> lstr = new List<string>(){ "C# Tutorials", "VB.NET Tutorials", "Learn C++", "MVC Tutorials", "Java" };

            var li8 = lstr.SelectMany(obj => obj);
            foreach(var x in li8)
            {
                Console.WriteLine(x);
            }



            List<Employee> employees = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Preety", Gender = "Female", Salary = 60000,
                              Technology = new List<string>() {"C#", "Jave", "C++"} },
                new Employee {ID = 102, Name = "Priyanka", Gender = "Female", Salary = 50000,
                              Technology =new List<string>() { "WCF", "SQL Server", "C#" } },
                new Employee {ID = 103, Name = "Hina", Gender = "Female", Salary = 40000,
                              Technology =new List<string>() { "MVC", "Jave"}},
                new Employee {ID = 104, Name = "Hina", Gender = "Female", Salary = 40000,
                              Technology =new List<string>() { "MVC", "Jave"}},
            };


            Console.WriteLine();
            Console.WriteLine("Using selectmany with method syntax with class and object");

            var li9 = (employees.SelectMany(obj => obj.Technology )).ToList();
            foreach (var x in li9)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine("Using where with query syntax with class and object");

            var li10 = from emp in employees
                       where emp.Technology.Count == 2
                       select new
                       {
                           Id = emp.ID,
                           Name = emp.Name
                       };
            foreach (var x in li10)
            {
                Console.WriteLine("Id = "+x.Id+" Name = "+x.Name);
            }


            Console.WriteLine();
            Console.WriteLine("Using where with method syntax with class and object");

            var li11 = employees.Where(obj => obj.Technology.Count == 2).Select(obj => new
                                                                            {
                                                                                Id = obj.ID,
                                                                                Name = obj.Name
                                                                            });
            foreach (var x in li11)
            {
                Console.WriteLine("Id = " + x.Id + " Name = " + x.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Using orderby with method syntax with class and object in ascending order");

            var li12 = employees.Where(obj => obj.ID > 101).OrderBy(obj => obj.Name);
            
            foreach (var x in li12)
            {
                Console.WriteLine("Id = " + x.ID + " Name = " + x.Name);
            }


            Console.WriteLine();
            Console.WriteLine("Using orderby with method syntax with class and object in descending order");
            var li15 = employees.Where(obj => obj.ID > 101).OrderByDescending(obj => obj.Name).ToList();

            foreach (var x in li15)
            {
                Console.WriteLine("Id = " + x.ID + " Name = " + x.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Using orderby with query syntax with class and object in ascending order");

            var li13 = (from emp in employees
                        where emp.ID > 101
                        orderby emp.Name
                        select emp).ToList();

            foreach (var x in li13)
            {
                Console.WriteLine("Id = " + x.ID + " Name = " + x.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Using orderby with query syntax with class and object in descending order");

            var li16 = (from emp in employees
                        where emp.ID > 101
                        orderby emp.Name descending
                        select emp).ToList();

            foreach (var x in li16)
            {
                Console.WriteLine("Id = " + x.ID + " Name = " + x.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Using orderby with query syntax with class and object with multiple property to sort in ascending order");

            var li14 = (from emp in employees
                       where emp.ID > 101
                       orderby emp.Name,emp.ID
                       select emp).ToList();

            foreach (var x in li14)
            {
                Console.WriteLine("Id = " + x.ID + " Name = " + x.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Using orderby with query syntax with class and object with multiple property to sort in descending order");
            var li17 = (from emp in employees
                        where emp.ID > 101
                        orderby emp.Name , emp.ID descending
                        select emp).ToList();

            foreach (var x in li17)
            {
                Console.WriteLine("Id = " + x.ID + " Name = " + x.Name);
            }


            Console.WriteLine();
            Console.WriteLine("Using orderby with method syntax with class and object with multiple property to sort in ascending order");
            var li18 = employees.Where(obj => obj.ID > 101).OrderBy(obj => obj.Name).ThenBy(obj => obj.ID).ToList();

            foreach (var x in li18)
            {
                Console.WriteLine("Id = " + x.ID + " Name = " + x.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Using orderby with method syntax with class and object with multiple property to sort in descending order");
            var li19 = employees.Where(obj => obj.ID > 101).OrderByDescending(obj => obj.Name).ThenBy(obj => obj.ID).ToList();

            foreach (var x in li19)
            {
                Console.WriteLine("Id = " + x.ID + " Name = " + x.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Using orderby with method syntax with class and object with multiple property to sort the first cond, in ascending  order and then the next cond, in descending order");
            var li20 = employees.Where(obj => obj.ID > 101).OrderBy(obj => obj.Name).ThenByDescending(obj => obj.ID).ToList();

            foreach (var x in li20)
            {
                Console.WriteLine("Id = " + x.ID + " Name = " + x.Name);
            }

            
            string []arr = { "C# Tutorials","VB.NET Tutorials","Learn C++","MVC Tutorials" ,"Java"  };



            Console.WriteLine();
            Console.WriteLine("Reverse for IEnumerable in query syntax");

            var li21 = (from obj in arr
                        select obj).Reverse();
            foreach (var x in li21)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine();
            Console.WriteLine("Reverse for List and converting into IEnumerable in method syntax");

            List<String> sli  = new List<string>(){ "C# Tutorials", "VB.NET Tutorials", "Learn C++", "MVC Tutorials", "Java" };
            var li22 = sli.AsEnumerable().Reverse();
            foreach (var x in li22)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine();
            Console.WriteLine("Reverse for List and converting into IQueryable in method syntax");

            IList<String> sli1 = new List<string>() { "C# Tutorials", "VB.NET Tutorials", "Learn C++", "MVC Tutorials", "Java" };
            sli.Add("");
            var li23 = sli1.AsQueryable().Reverse();
            foreach (var x in li23)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine();
            Console.WriteLine("Take operator by method syntax");
            var li24 = employees.Where(obj => obj.ID > 101).Take(2);

            foreach(var x in li24)
            {
                Console.WriteLine("Id = "+x.ID + " Name = "+x.Name);
            }


            List<int> lii = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine();
            Console.WriteLine("Finding max");
           
            var li25  = lii.Max();
            Console.WriteLine("Max element " + li25);

            Console.WriteLine();
            Console.WriteLine("Finding even max");
     
            var li26 = lii.Max( obj => {
                if (obj % 2 == 0)
                    return obj;
                else
                    return 0;

                });
            Console.WriteLine("Max element " + li26);

            //var li27 = lii.Max(obj=>obj);
            //Console.WriteLine("Max element " + li27);

            Console.WriteLine();
            Console.WriteLine("Finding sum");

            var li27 = lii.Sum();
            Console.WriteLine("Sum =  " + li27);


            Console.WriteLine();
            Console.WriteLine("Finding sum of even nos");

            var li28 = lii.Sum(obj => {
                if (obj % 2 == 0)
                    return obj;
                else
                    return 0;

            });
            Console.WriteLine("Max element " + li28);



        }
    }
}

