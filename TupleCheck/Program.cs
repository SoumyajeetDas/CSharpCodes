using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleCheck
{
    class Program
    {
        //public static Tuple<int,int> Math(int a , int b)
        //{
        //    int sum = a + b;
        //    int prod = a * b;
        //    var t1 = Tuple.Create(sum, prod);
        //    return t1;
        //}

        public static (int ,int ) Math(int a, int b)
        {
            int sum = a + b;
            int prod = a * b;

            return (sum, prod);
        }

        public static (int Sum , int Prod) Math1(int a, int b)
        {
            int sum = a + b;
            int prod = a * b;

            return (Sum :sum, Prod: prod);
        }
        static void Main(string[] args)
        {
            //Tuple<int, string, string> t1 = new Tuple<int,string,string>(1,"Sounak","Dippya");
            //Console.WriteLine(t1.Item1);
            //Console.WriteLine(t1.Item2);
            //Console.WriteLine(t1.Item3);
            //Console.WriteLine();

            //Tuple<int, string, string> t2 = Tuple.Create(1, "Sounak", "Dippya");
            //Console.WriteLine(t1.Item1);
            //Console.WriteLine(t1.Item2);
            //Console.WriteLine(t1.Item3);
            //Console.WriteLine();

            //var t3 = Tuple.Create(1, "Sounak", "Dippya");
            //Console.WriteLine(t1.Item1);
            //Console.WriteLine(t1.Item2);
            //Console.WriteLine(t1.Item3);
            //Console.WriteLine();

            //Tuple<int, int> t4 = Math(2, 3);
            //Console.WriteLine("Addition = "+t4.Item1);
            //Console.WriteLine("Multiplication = "+t4.Item2);

            (int, string, string) t1 = (1, "Soumya", "Sounak");
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);
            Console.WriteLine(t1.Item3);
            Console.WriteLine();

            (int id, string name1, string name2) t2 = (1, "Soumya", "Sounak");
            Console.WriteLine(t2.id);
            Console.WriteLine(t2.name1);
            Console.WriteLine(t2.name2);
            Console.WriteLine();


            var t3 = (id:1, Name1 :"Soumya", Name2:"Sounak");
            Console.WriteLine(t3.id);
            Console.WriteLine(t3.Name1);
            Console.WriteLine(t3.Name2);
            Console.WriteLine();

            (int sum, int prod) t4 = Math(2, 3);
            //var t4 = Math(2, 3);
            Console.WriteLine("Addition : " + t4.sum);
            Console.WriteLine("Product : " + t4.prod);

            (int sum, int prod) t5 = Math(2, 3);
          
            Console.WriteLine("Addition : " + t5.sum);
            Console.WriteLine("Product : " + t5.prod);


            
        }
    }
}
