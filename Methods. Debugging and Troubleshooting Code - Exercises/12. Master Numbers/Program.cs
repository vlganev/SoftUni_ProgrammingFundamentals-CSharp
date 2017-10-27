using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int number = 1; number < N; number++)
            {
                if (isDevisibleBy7(number) && isOneDigitEven(number) && isSymmetric(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        private static bool isOneDigitEven(int number)
        {
            while (number != 0)
            {
                if (number % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        private static bool isDevisibleBy7(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool isSymmetric(int number)
        {
            string numberString = number.ToString();
            string first = numberString.Substring(0, numberString.Length / 2);
            char[] arr = numberString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            if (first.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
