using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> reversedNumbersList = new List<int>();

            for (int i = 0; i < initialList.Count; i++)
            {
                int number = initialList[i];
                int reversed = 0;
                int left = number;
                while (number>0)
                {
                    int rev = number % 10;
                    reversed = reversed * 10 + rev;
                    number = number / 10;
                }
                reversedNumbersList.Add(reversed);
            }
            int totalSum = reversedNumbersList.Sum(x => Convert.ToInt32(x));
            Console.WriteLine(totalSum);
        }
    }
}
