using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldАndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] firstrow = new int[input.Length/2];
            int[] secondrow = new int[input.Length / 2];
            int[] sum = new int[input.Length / 2];

            for (int i = 0; i < input.Length / 4; i++)
            {
                firstrow[i] = input[input.Length / 4 - 1-i];

                firstrow[firstrow.Length/2 + i] = input[input.Length - i-1];
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                secondrow[i] = input[input.Length / 4 + i];
            }
            for (int i = 0; i < input.Length/2; i++)
            {
                sum[i] = firstrow[i] + secondrow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
