using System;

namespace CountTheIntegers
{
    class Program
    {
        public static void Main()
        {
            for (int i = 0; i <= 100; i++)
            {
                var input = Console.ReadLine();
                int intintput = 0;
                if (!int.TryParse(input, out intintput))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
