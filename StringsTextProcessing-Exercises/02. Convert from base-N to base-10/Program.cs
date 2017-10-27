using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger baseNumber = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            BigInteger sum = 0;
            int count = 0;
            while (number>0)
            {
                BigInteger tempnumber = number % 10;
                BigInteger multiplier = 1;
                for (int i = 1; i <= count; i++)
                {
                    multiplier *= baseNumber;
                }
                BigInteger localSum = tempnumber * multiplier;
                count++;
                number = number / 10;
                sum += localSum;
            }
            Console.WriteLine(sum);
        }
    }
}
