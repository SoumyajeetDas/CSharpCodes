using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Status
{
    class Program
    {
        public static Dictionary<string, DateTime> flightSchedule = new Dictionary<string, DateTime>(){
                                                        {"ZW346", Convert.ToDateTime("13:54:10")},
                                                        {"AT489", Convert.ToDateTime("16:30:00")},
                                                         {"BR267", Convert.ToDateTime("21:15:30")}};
        public static string flightStatus(string flightNo) //DO NOT CHANGE the 'flightStatus' method signature
        {

            //Implement your code here
            DateTime dt = flightSchedule[flightNo];
            if(DateTime.UtcNow<dt)
            {
                TimeSpan t = dt - DateTime.UtcNow;
                return "Time To Flight " + t;
            }
            else
            {
                return "Flight Already Left";
            }
          

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Flight Number : ");
            string s = Console.ReadLine();
            string res = flightStatus(s);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        
    }
}
