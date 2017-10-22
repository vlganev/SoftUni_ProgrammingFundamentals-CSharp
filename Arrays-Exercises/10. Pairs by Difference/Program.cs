using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
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
            int difference = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < element.Length; i++)
            {
                for (int j = i + 1; j < element.Length; j++)
                {
                    if (difference == Math.Abs(element[i]-element[j]))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
