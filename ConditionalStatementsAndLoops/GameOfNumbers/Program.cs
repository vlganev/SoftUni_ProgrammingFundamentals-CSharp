using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            var theNumber1 = "null";
            var theNumber2 = "null";
            int combinations = 0;

            for (int d1 = N; d1 <= M; d1++)
            {
                for (int d2 = N; d2 <= M; d2++)
                {
                    if (d1 + d2 == magicalNumber)
                    {
                        theNumber1 = d1.ToString();
                        theNumber2 = d2.ToString();
                    }
                    combinations++;
                }
            }
            if (theNumber1 == "null" && theNumber2 == "null")
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
            }
            else
            {
               Console.WriteLine($"Number found! {theNumber1} + {theNumber2} = {magicalNumber}");
            }
        }
    }
}
