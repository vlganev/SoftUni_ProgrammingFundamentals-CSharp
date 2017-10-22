using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                bool isPrime = true;
                var boundary = (int)Math.Floor(Math.Sqrt(number));
                for (int k = 2; k <= boundary; k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (i % 2 == 0) isPrime = false;
                if (i == 2) isPrime = true;

                if (i != 0 || i !=1)
                { 
                    Console.WriteLine($"{i} -> {isPrime}");
                }
            }

        }
    }
}
