using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstArg = input[0];
            string secondArg = input[1];

            BigInteger sum = 0;
            string ls = string.Empty;
            ls = firstArg.Length > secondArg.Length ? firstArg : secondArg;

            for (int i = 0; i < Math.Max(firstArg.Length, secondArg.Length); i++)
            {
                if (i >= Math.Min(firstArg.Length, secondArg.Length))
                {

                    sum += ls[i];
                }
                else
                {
                sum += firstArg[i] * secondArg[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
