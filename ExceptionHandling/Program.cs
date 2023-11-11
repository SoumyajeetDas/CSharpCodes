using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class MyException : Exception
    {
        public MyException(string s):base(s)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int age = 19;
            try
            {
                if (age < 18)
                {
                    throw new MyException("Less age");
                    
                }
                else
                {
                    Console.WriteLine("Perfect age");
                    Console.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Make it Correct");
                Console.ReadLine();
            }
            
        }
    }

    
    
}
