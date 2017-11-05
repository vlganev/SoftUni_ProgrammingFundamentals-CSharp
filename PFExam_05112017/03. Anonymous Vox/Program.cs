using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main()
        {
            List<string> listFound = new List<string>();
            string encodedText = Console.ReadLine();
            string placeholders = Console.ReadLine();

            string encodedTextPattern = @"([a-zA-Z]+)([\x20-\xFF]+)(\1)";

            char[] delimiters = { '{', '}' };
            string[] placeholdersTokens = placeholders.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Regex encodedTextRegex = new Regex(encodedTextPattern);
            MatchCollection encodedTextMatches = encodedTextRegex.Matches(encodedText);

            foreach (Match item in encodedTextMatches)
            {
                if (item.Groups[1].Value != "")
                {
                    listFound.Add(item.Groups[2].Value);
                }
            }
            string result = encodedText;
            for (int i = 0; i < listFound.Count; i++)
            {
                result = result.Replace(listFound[i].Trim(), placeholdersTokens[i].Trim());
            }
            Console.WriteLine(result);

            

        }
    }
}
