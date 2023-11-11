using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Duplicate
{
    class Program
    {
        
        public static int countDuplicate(List<int> numbers)
        {
            HashSet<int> h = new HashSet<int>();
            for(int i=0;i<numbers.Count;i++)
            {
                for(int j=i+1;j<numbers.Count-1;j++)
                {
                    if(numbers[i]==numbers[j])
                    {
                        h.Add(numbers[i]);
                        break;
                    }
                }
            }
            return h.Count;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 3, 3, 5, 5, 4, 4, 4, };
            Console.WriteLine(countDuplicate(numbers));
        }
    }
}
