using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Soumyajeet";
            Console.WriteLine(s.FirstLetterString());
            Console.WriteLine(StringHelper.FirstLetterString(s));

            Console.WriteLine(s.CheckLength(19));
            Console.WriteLine(StringHelper.CheckLength(s,19));
        }
    }
}
