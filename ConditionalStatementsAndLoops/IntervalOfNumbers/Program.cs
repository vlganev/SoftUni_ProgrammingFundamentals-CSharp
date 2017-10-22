using System;

namespace IntervalOfNumbers
{
    class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                while (b<=a)
                {
                    Console.WriteLine(b);
                    b++;
                }
            }
            else
            {
                while (a <= b)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }
        }
    }
}
