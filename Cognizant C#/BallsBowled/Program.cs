using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsBowled
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of overs");
            int overs = int.Parse(Console.ReadLine());

            PlayerBO pb = new PlayerBO();
            pb.AddOversDetails(overs);
        }
    }
    public class PlayerBO      //DO NOT change the class name
    {
        public List<int> PlayerList { get; set; } = new List<int>();
        int balls;

        public void AddOversDetails(int oversBowled)       //DO NOT change the method signature
        {
            //Implement code here
            PlayerList.Add(oversBowled);
            //Console.WriteLine(PlayerList);
            foreach (int i in PlayerList)
            {
                balls = i;
                Console.WriteLine(balls);
            }
            Console.WriteLine("Balls Bowled : " + GetNoOfBallsBowled());
        }

        public int GetNoOfBallsBowled()              //DO NOT change the method signature
        {
            //Implement code here
            return balls * 6;
        }
    }
}
