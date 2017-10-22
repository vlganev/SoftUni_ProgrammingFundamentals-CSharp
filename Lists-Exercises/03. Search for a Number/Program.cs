using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialNumbers = Console
                .ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            int[] searchNumbers = Console
                .ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            bool found = false;

            initialNumbers.Take(searchNumbers[0]);
            initialNumbers.RemoveRange(0, searchNumbers[1]);

            if (initialNumbers.Contains(searchNumbers[2]))
            {
                found = true;
            }
            
            if (found)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
