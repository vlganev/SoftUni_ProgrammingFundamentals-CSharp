using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string textKeys = Console.ReadLine();
            string text = Console.ReadLine();

            string patternForKeys = @"^(\w+)[\<\|\\]\w*[\<\|\\](\w*)";
            Match matchedResultKeys = Regex.Match(textKeys, patternForKeys);
            string startKey = matchedResultKeys.Groups[1].ToString();
            string endKey = matchedResultKeys.Groups[2].ToString();
            
            string patternForText = $@"{startKey}(.*?){endKey}";

            MatchCollection matches = Regex.Matches(text, patternForText);
            if (matches.Count == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                foreach (Match match in matches)
                {
                    Console.Write(match.Groups[1]);
                }
            }
        }
    }
}
