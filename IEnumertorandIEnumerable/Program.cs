using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumertorandIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>()
            { 1990,1991,1992,1993,2001,2002,2003};

            using (IEnumerator<int> iemumerat = years.GetEnumerator()) //As IEnumerator inherits the interface IDisposable so used using
            {
                while (iemumerat.MoveNext())
                {
                    //Console.WriteLine(iemumerat.Current.ToString());
                    Console.WriteLine(Convert.ToInt32(iemumerat.Current));
                }
            }

            year1990to1993(years.GetEnumerator());
        }

        static void year1990to1993(IEnumerator<int> ienumerat)
        {

            Console.WriteLine("From the year 1990 to 1993");
            while (ienumerat.MoveNext())
            {
                if (Convert.ToInt32(ienumerat.Current) > 1993)
                {
                    year2001to2003(ienumerat);
                }
                else
                {
                    Console.WriteLine(ienumerat.Current.ToString());
                }
            }
        }

        static void year2001to2003(IEnumerator<int> ienumerat)
        {
            Console.WriteLine();
            Console.WriteLine("From the year 2001 to 2003");
            //ienumerat.Reset();
            while (ienumerat.MoveNext())
            {
                Console.WriteLine(ienumerat.Current.ToString());
            }
        }
    }
}
