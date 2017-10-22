using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] element = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long len = 1;
            long bestLen = 1;
            long bestStart = 0;
            for (long i = 0; i < element.Length; i++)
            {
                for (long j = i+1; j < element.Length; j++)
                {
                    if (element[i] == element[j])
                    {
                        len++;
                    }
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = i;
                }
                len = 1;
            }
            Console.WriteLine(element[bestStart]);
        }
    }
}
