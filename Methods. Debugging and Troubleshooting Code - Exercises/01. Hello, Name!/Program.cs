﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHelloName(name);
        }

        private static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
