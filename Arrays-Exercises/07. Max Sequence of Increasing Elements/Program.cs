using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] element = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int len = 1;
            int start = 0;
            int bestLen = 1;
            int bestStart = 0;
            for (int i = 1; i < element.Length; i++)
            {
                if (element[i] > (element[i -1]))
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }
            }
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(element[i] + " ");
            }
        }
    }
}
