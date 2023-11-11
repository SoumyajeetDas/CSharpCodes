using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewMemeber
{
    class Program
    {
        static Dictionary<int, string> groupInfo = new Dictionary<int, string>() { { 1, "Gold" }, { 2, "Silver" }, { 3, "Platinum" } };
        static Dictionary<int, List<String>> memberInfo = new Dictionary<int, List<String>>() {
                                    { 1, new List<string>(){ "Tom","Harry"} },
                                    { 2,new List<string>(){ "Sam","Peter"} },
                                    { 3,new List<string>(){ "Kim","Robert"} } };
        static void Main(string[] args)
        {
            int key = 0;
            Console.WriteLine("Group Name : ");
            String grp = Console.ReadLine();
            foreach (var kvp in groupInfo)
            {
                if (grp == kvp.Value)
                {
                    key = kvp.Key;
                    break;
                }
            }

            List<string> li = new List<string>();
            li = memberInfo[key];
            Console.WriteLine("Member Name:");
            String member = Console.ReadLine();
            li.Add(member);

            foreach (var x in li)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
