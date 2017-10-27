using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 2; i <= N; i++)
            {
                factorial *= i;
            }
            int count = 0;
            while (factorial > 0 && factorial % 10 == 0)
            {
                factorial = factorial / 10;
                count++;
            }
            //if (count == 1)
            //{
            //    Console.WriteLine($"{N}! = {factorial} -> One trailing zero");
            //}
            //else
            //{
            //    Console.WriteLine($"{N}! = {factorial} -> {count} trailing zeroes");
            //}
            Console.WriteLine(count);
        }
    }
}
