using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Age_of_Person
{
    public class Person
    {
        //Fill code here
        private string firstName;
        private string lastname;
        private DateTime dob;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string Lastname
        {
            set
            {
                lastname = value;
            }
            get
            {
                return lastname;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public string Adult
        {
            get
            {
                if (GetAge(DOB) > 18)
                {
                    return "Adult";
                }
                else
                {
                    return "Child";
                }
            }

        }

        public void DisplayDetails()
        {
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + Lastname);
            Console.WriteLine("Age: " + GetAge(DOB));
            Console.WriteLine(Adult);

        }

        public int GetAge(DateTime dob)
        {
            DateTime dt = DateTime.Now;
            int age = dt.Year - dob.Year;
            if (dob > dt.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Enter the first name");
            p.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            p.Lastname = Console.ReadLine();
            Console.WriteLine("Enter date of birth in yyyy/mm/dd/ format");
            p.DOB = Convert.ToDateTime(Console.ReadLine());
            p.DisplayDetails();
        }
    }
}
