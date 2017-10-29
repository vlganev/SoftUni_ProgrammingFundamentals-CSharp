﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"((?<=\s)[a-z0-9]*(?:\w+[-._]\w+)*@\w+([-.]\w+)*\.\w{2,}([-.]\w{2,})*)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
