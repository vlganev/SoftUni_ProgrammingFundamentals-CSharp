using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = string.Empty;
            using (StreamReader reader = new StreamReader(@"..\..\input.txt", Encoding.GetEncoding("UTF-8")))
            {
                string line = "x";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        var chars = line.ToCharArray();

                        for (int i = 0; i < line.Length; i++)
                        {
                            output += $"{line[i]} -> {(int)line[i] % 32 - 1}" + Environment.NewLine;
                        }
                    }
                    output += Environment.NewLine;
                }
            }
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                writer.WriteLine(output);
            }
        }
    }
}
