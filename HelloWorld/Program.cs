﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string branch = "MASTER";
            Console.WriteLine($"Current branch is : {branch}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
