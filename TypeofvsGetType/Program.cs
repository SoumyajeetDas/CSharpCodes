﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeofvsGetType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine(a.GetType());
            Console.WriteLine(typeof(int));
        }
    }
}
