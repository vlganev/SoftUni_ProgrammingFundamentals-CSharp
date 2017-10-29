using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string elements = Console.ReadLine();
            int skip = numbers[0];
            int take = numbers[1];

            string pattern = @"(?<=\|<)(\w{" + skip + @"})(\w{0," + take + "})";
            MatchCollection matchedResult = Regex.Matches(elements, pattern);

            string result = string.Join(", ", from Match match in matchedResult select match.Groups[2]);
            Console.WriteLine(result);
        }
    }
}
