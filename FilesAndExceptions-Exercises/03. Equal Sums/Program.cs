using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
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
                    if (string.IsNullOrEmpty(line))
                        break;
                    int[] element = line
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                    bool found = false;
                    for (int i = 0; i < element.Length; i++)
                    {
                        long sumLeft = 0;
                        long sumRight = 0;
                        for (int j = 0; j < i; j++)
                        {
                            sumLeft += element[j];
                        }
                        for (int k = i + 1; k < element.Length; k++)
                        {
                            sumRight += element[k];
                        }
                        if (sumLeft == sumRight)
                        {
                            using (StreamWriter writer = new StreamWriter(path + "output.txt", append: true))
                            {
                                writer.WriteLine($"{line} -> {i}");
                            }
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        using (StreamWriter writer = new StreamWriter(path + "output.txt", append: true))
                        {
                            writer.WriteLine($"{line} -> No");
                        }
                    }
                }
            }
        }
    }
}
