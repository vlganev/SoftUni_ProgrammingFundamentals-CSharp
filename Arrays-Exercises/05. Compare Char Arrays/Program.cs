using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] wordA = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] wordB = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            bool firstIsFirst = true;
            bool areEqual = true;
            for (int i = 0; i < Math.Min(wordA.Length, wordB.Length); i++)
            {
                if (wordB[i] < wordA[i])
                {
                    firstIsFirst = false;
                }
                if (wordA[i] != wordB[i])
                {
                    areEqual = false;
                }
            }

            if (areEqual && wordA.Length < wordB.Length)
            {
                Console.WriteLine(string.Join("", wordA));
                Console.WriteLine(string.Join("", wordB));
            }
            else if (areEqual && wordA.Length > wordB.Length)
            {
                Console.WriteLine(string.Join("", wordB));
                Console.WriteLine(string.Join("", wordA));
            }
            else if (firstIsFirst)
            {
                Console.WriteLine(string.Join("",wordA));
                Console.WriteLine(string.Join("", wordB));
            }
            else
            {
                Console.WriteLine(string.Join("", wordB));
                Console.WriteLine(string.Join("", wordA));
            }
        }
    }
}
