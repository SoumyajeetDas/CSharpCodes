using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#\Myfile.txt";
            using (FileStream file = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine("Soumyajeet Das");
                    writer.WriteLine("Kalua");
                    writer.WriteLine("Dippya");
                    Console.WriteLine("File created");
                }
            }

            using (FileStream file = new FileStream(path,FileMode.Open))
            {
                using(StreamReader reader = new StreamReader(file))
                {
                    //string line = reader.ReadLine();
                    if(reader.Peek()>0)
                    {
                        string data = reader.ReadToEnd();
                        Console.WriteLine(data);
                    }
                    else
                    {
                        Console.WriteLine("No data in file"+reader.Peek());
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
