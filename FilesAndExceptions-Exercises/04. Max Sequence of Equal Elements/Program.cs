using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_SequenceОfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\";
            if (File.Exists(path + "output.txt"))
                File.Delete(path + "output.txt");

            using (StreamReader reader = new StreamReader(path + "input.txt", Encoding.GetEncoding("UTF-8")))
            {
                string line = "x";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line)) break;
                    int[] element = line
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    int len = 1;
                    int start = 0;
                    int bestLen = 1;
                    int bestStart = 0;
                    for (int i = 1; i < element.Length; i++)
                    {
                        if (element[i] == element[start])
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
                    using (StreamWriter writer = new StreamWriter(path + "output.txt", append: true))
                    {
                        writer.Write($"{line} -> ");

                        for (int i = bestStart; i < bestStart + bestLen; i++)
                        {
                            writer.Write(element[i] + " ");
                        }
                        writer.Write(Environment.NewLine);
                    }
                }
            }
        }
    }
}
