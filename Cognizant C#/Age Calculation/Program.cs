using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            //Implement code here
            string dob = Console.ReadLine();
            int res = calculateAge(dob);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int calculateAge(string dateOfBirth)
        {
            //Implement code here
            DateTime dob;
            DateTime.TryParseExact(dateOfBirth, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out dob);
            int age = DateTime.Now.Year - dob.Year;
            if (dob > DateTime.Now.AddYears(-age))
            {
                age--;
            }
            else
            {
                age++;
            }
            return age;

        }
    }
}
