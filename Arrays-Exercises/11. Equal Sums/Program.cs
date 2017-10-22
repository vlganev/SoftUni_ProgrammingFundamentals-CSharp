using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
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

            for (int i = 0; i < element.Length; i++)
            {
                long sumLeft = 0;
                long sumRight = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += element[j];
                }
                for (int k = i+1; k < element.Length; k++)
                {
                    sumRight += element[k];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
                Console.WriteLine("no");
        }
    }
}
