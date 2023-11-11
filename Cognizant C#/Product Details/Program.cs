using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Product_Details
{
    class Program
    {
        static void Main(string[] args)
        {
            string pname, psno;
            DateTime pdate = new DateTime();
            double pcost;
            List<Product> li = new List<Product>();



            using (FileStream file = new FileStream(@"D:\C#\Cognizant C#\input.txt", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] value = line.Split(',');
                        pname = value[0].Trim();
                        psno = value[1].Trim();
                        DateTime.TryParseExact(value[2].Trim(), "dd-MM-yyyy", null, DateTimeStyles.None, out pdate);
                        pcost = Convert.ToDouble(value[3].Trim());
                        // Product obj = new Product(pname, psno, pdate, pcost);
                        li.Add(new Product(pname, psno, pdate, pcost));
                    }
                }
            
            Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name", "Serial Number", "Purchase Date", "Purchase Cost"));
                foreach (var x in li)
                {
                    Console.WriteLine(x.ToString());
                }
                Console.ReadKey();
            }
        }
    }
}
