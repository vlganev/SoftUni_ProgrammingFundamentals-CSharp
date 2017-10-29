using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternDidimon = @"[^a-zA-Z-]+";
            string patternBojomon = @"([A-Za-z]+)-([A-Za-z]+)";
            Regex didimon = new Regex(patternDidimon);
            Regex bojomon = new Regex(patternBojomon);

            int count = 1;

            while (true)
            {
                if (count % 2 == 1)
                {
                    Match didimonMatch = didimon.Match(input);
                    if (didimonMatch.Success)
                    {
                        Console.WriteLine(didimonMatch.Value);
                        input = input.Remove(0, didimonMatch.Index);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Match bojomonMatch = bojomon.Match(input);
                    if (bojomonMatch.Success)
                    {
                        Console.WriteLine(bojomonMatch.Value);
                        input = input.Remove(0, bojomonMatch.Index);
                    }
                    else
                    {
                        break;
                    }
                }
                count++;
            }
        }
    }
}
