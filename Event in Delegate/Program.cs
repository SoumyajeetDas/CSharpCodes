using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_in_Delegate
{
    public delegate void Transformer(int x);
    class Program
    {
        static void Main(string[] args)
        {
            NotificationofMethods nm = new NotificationofMethods();
            nm.transformerevent += User1.Xhandler; //Register with event
            nm.transformerevent += User2.Yhandler; //Register with event
            nm.NotifyOnCell(1);
            Console.WriteLine();
            Console.WriteLine("After doing -=");
            nm.transformerevent -= User1.Xhandler;
            nm.NotifyOnCell(1);

        }
    }
    class NotificationofMethods //Publisher
    {
        public event Transformer transformerevent;
        public void NotifyOnCell(int x)
        {
            transformerevent?.Invoke(x);
        }
    }

    class User1 //Subsriber
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event Received by User1 object");
        }
    }

    class User2 //Subscriber
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event Received by User2 object");
        }
    }
}
