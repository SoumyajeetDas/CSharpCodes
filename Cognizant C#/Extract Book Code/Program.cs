using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Book_Code
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the book code of length 18");
            string code = Console.ReadLine();
            string d_code = code.Substring(0, 3);
            string yop = code.Substring(3, 4);
            string nop = code.Substring(7, 5);
            string b_id = code.Substring(12);
            if (code.Length == 18)
            {
                if (d_code == "101" || d_code == "102" || d_code == "103")
                {
                    Console.WriteLine("Department Code  :" + d_code);
                }
                else
                {
                    Console.WriteLine("Invalid Department Code");
                }
                if (Convert.ToInt32(yop) >= 1900 && Convert.ToInt32(yop) <= 2020)
                {
                    Console.WriteLine("Year of Publication  :" + yop);
                }
                else
                {
                    Console.WriteLine("Invalid Year");
                }
                if (Convert.ToInt32(nop) >= 00001 && Convert.ToInt32(nop) <= 99999)
                {
                    Console.WriteLine("Number of pages  :" + nop);
                }
                else
                {
                    Console.WriteLine("Invalid Page Numbers");
                }
                char c = b_id[0];
                int flag = 0;

                if (Char.IsLetter(c))
                {
                    string cbid = b_id.Substring(1);
                    for (int i = 0; i < cbid.Length; i++)
                    {
                        if (Char.IsNumber(cbid, i) == false)
                        {
                            flag = 1;
                            break;
                        }
                    }

                }
                else
                {
                    flag = 1;
                }
                if (flag == 1)
                {
                    Console.WriteLine("Invalid Book ID");
                }
                else
                {
                    Console.WriteLine("Book ID  :" + b_id);
                }

            }
            else
            {
                Console.WriteLine("Invalid Book Code");
            }

            Console.ReadLine();
        }
    }
}
