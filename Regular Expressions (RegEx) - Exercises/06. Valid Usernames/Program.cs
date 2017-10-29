using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validUsernames = new List<string>();
            string pattern = @"\b([a-zA-Z][\w]{2,24})\b";
            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                validUsernames.Add(match.ToString());
            }

            long maxSum = 0;
            int firstUsername = 0;

            for (int i = 1; i < validUsernames.Count; i++)
            {
                long localSum = 0;
                localSum = validUsernames[i - 1].Length + validUsernames[i].Length;
                if (localSum > maxSum)
                {
                    maxSum = localSum;
                    firstUsername = i - 1;
                }
            }
            for (int i = firstUsername; i < firstUsername+2; i++)
            {
                Console.WriteLine(validUsernames[i]);
            }
        }
    }
}
