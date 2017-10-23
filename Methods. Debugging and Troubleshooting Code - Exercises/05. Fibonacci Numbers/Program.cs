using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibonacciNumber = findFibonacciNumber(n);
            Console.WriteLine(fibonacciNumber);
        }

        private static int findFibonacciNumber(int n)
        {
            int fibonacciNumber = 0;
            int add = 1;
            int prevAdd = 0;
            if (n == 0)
            {
                fibonacciNumber = 1;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    fibonacciNumber = add + prevAdd;
                    prevAdd = add;
                    add = fibonacciNumber;

                }
            }
            return fibonacciNumber;
        }
    }
}
