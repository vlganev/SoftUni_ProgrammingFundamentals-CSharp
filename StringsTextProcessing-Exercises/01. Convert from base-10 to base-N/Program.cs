using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger baseNumber = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            string baseFinalNumber = string.Empty;
            while (number > 0)
            {
                BigInteger currDigit = number % baseNumber;
                baseFinalNumber += currDigit;

                number = number / baseNumber;
            }
            Console.WriteLine(baseFinalNumber.ToCharArray().Reverse().ToArray());
        }
    }
}
