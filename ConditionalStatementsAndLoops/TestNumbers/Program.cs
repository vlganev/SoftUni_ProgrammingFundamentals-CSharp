using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxBoundary = int.Parse(Console.ReadLine());

            int sum = 0;
            int countcomb = 0;
            for (int d1 = N; d1 > 0; d1--)
            {

                for (int d2 = 1; d2 <= M; d2++)
                {
                    if (sum >= maxBoundary)
                    {
                        break;
                    }
                    sum += 3 * d1 * d2;
                    countcomb++;
                }
                
            }
            if (sum < maxBoundary)
            {
                Console.WriteLine($"{countcomb} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"{countcomb} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxBoundary}");
            }
        }
    }
}
