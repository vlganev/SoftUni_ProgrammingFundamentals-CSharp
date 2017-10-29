using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"([^&=?\s]*)(?=\=)=(?<=\=)([^&=\s]*)";
            string patternSpace = @"((%20|\+)+)";
            Regex regex = new Regex(pattern);
            while (true)
            {
                Dictionary<string, List<string>> localdict = new Dictionary<string, List<string>>();
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    string keyRoughParsed = match.Groups[1].Value;
                    string key = Regex.Replace(keyRoughParsed, patternSpace, word => " ").Trim();
                    string valueRoughParsed = match.Groups[2].Value;
                    string value = Regex.Replace(valueRoughParsed, patternSpace, word => " ").Trim();

                    if (!localdict.ContainsKey(key))
                    {
                        List<string> values = new List<string> { value };
                        localdict.Add(key, values);
                    }
                    else
                    {
                        localdict[key].Add(value);
                    }
                }
                foreach (var result in localdict)
                {
                    Console.Write($"{result.Key}=[{string.Join(", ", result.Value)}]");

                }
                Console.WriteLine();
            }
        }
    }
}
