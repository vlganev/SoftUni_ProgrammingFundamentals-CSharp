using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\input.txt");
            string output = string.Empty;
            foreach (var line in lines)
            {
                long[] element = line
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(long.Parse)
               .ToArray();
                long len = 1;
                long bestLen = 1;
                long bestStart = 0;
                for (long i = 0; i < element.Length; i++)
                {
                    for (long j = i + 1; j < element.Length; j++)
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
                output += line + " -> " + element[bestStart] + Environment.NewLine;

        }
            output += "END" + Environment.NewLine + Environment.NewLine;
            File.AppendAllText(@"..\..\output.txt", output);
        }
    }
}
