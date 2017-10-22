using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> initialList = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            List<int> bombNumbers = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int bombNumber = bombNumbers[0];
            int power = bombNumbers[1];

            while (initialList.Contains(bombNumber))
            {
                int index = initialList.IndexOf(bombNumber);
                int lastPower = initialList.Count - index;

                for (int i = index+power; i >= index-power; i--)
                {
                    if (i < 0 || i >= initialList.Count)
                    {
                        continue;
                    }
                    else
                    {
                        initialList.RemoveAt(i);
                    }
                }
            }
            decimal totalSum = initialList.Sum(x => Convert.ToInt32(x));
            Console.WriteLine(totalSum);
        }
    }
}
