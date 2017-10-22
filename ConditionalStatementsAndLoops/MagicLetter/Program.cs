using System;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            for (char d1 = a; d1 <= b; d1++)
            {
                for (char d2 = a; d2 <= b; d2++)
                {
                    for (char d3 = a; d3 <= b; d3++)
                    {
                        if (d1 == c || d2 == c || d3 == c)
                        {
                            
                        } 
                        else
                        { 
                            Console.Write($"{d1}{d2}{d3} ");
                        }
                    }
                }
            }
        }
    }
}
