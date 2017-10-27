using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            char firstWordFirstChar = firstWord[0];
            char firstWordLastChar = firstWord[firstWord.Length - 1];
            var firstWordNumber = firstWord.Substring(1, firstWord.Length - 2);
            
            char secondWordFirstChar = secondWord[0];
            char secondWordLastChar = secondWord[firstWord.Length - 1];
            var secondWordNumber = secondWord.Substring(1, secondWord.Length - 2);

            Console.WriteLine(firstWordFirstChar);
            Console.WriteLine(firstWordLastChar);
            Console.WriteLine(firstWordNumber);

        }
    }
}
