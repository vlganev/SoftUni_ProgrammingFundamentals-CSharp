using System;

namespace WordInPlural
{
    class Program
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var wordInPlural = "null";

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length-1);
                wordInPlural = word + "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                wordInPlural = word + "es";
            }
            else
            {
                wordInPlural = word + "s";
            }
            Console.WriteLine(wordInPlural);
        }
    }
}
