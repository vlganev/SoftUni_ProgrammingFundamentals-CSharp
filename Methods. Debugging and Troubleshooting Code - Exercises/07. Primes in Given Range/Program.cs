using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primeList = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                primeList = FindPrimesInRange(i, primeList);
            }
            Console.WriteLine(String.Join(", ", primeList));
        }

        private static List<int> FindPrimesInRange(int i, List<int> primeList)
        {
            if (isPrime(i))
            {
                primeList.Add(i);
            }
            return primeList;
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
