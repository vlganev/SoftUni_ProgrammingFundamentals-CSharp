using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string element = Console.ReadLine();
            var chars = element.ToCharArray();

            for (int i = 0; i < element.Length; i++)
            {
                Console.WriteLine($"{element[i]} -> {(int)element[i] % 32 - 1}");
            }
        }
    }
}
