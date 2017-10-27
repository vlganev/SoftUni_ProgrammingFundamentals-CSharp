using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));

                if (isPrime(number))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }

        }

        private static bool isPrime(long n)
        {
            if (n == 0 || n == 1 || n == 2)
            {
                return false;
            }
            for (int devider = 2; devider <= Math.Sqrt(n); devider++)
            {
                if (n % devider == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
