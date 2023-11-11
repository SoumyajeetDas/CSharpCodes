using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenableInterface
{
    interface IOpenable
    {
        String OpenSesame();
    }

    public class TreasureBox : IOpenable
    {
        public String OpenSesame()
        {
            return "Congratulations , Here is your lucky win";
        }
    }
    public class Parachute : IOpenable
    {
        public String OpenSesame()
        {
            return "Have a thrilling experience flying in air";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the letter found in the paper");
            String val = Console.ReadLine();
            switch (val)
            {
                case "T":
                    IOpenable io1 = new TreasureBox();
                    String str = io1.OpenSesame();
                    Console.WriteLine(str);
                    break;

                case "P":
                    IOpenable io = new Parachute();
                    str = io.OpenSesame();
                    Console.WriteLine(str);
                    break;

            }
            Console.ReadLine();
        }
    }
}
