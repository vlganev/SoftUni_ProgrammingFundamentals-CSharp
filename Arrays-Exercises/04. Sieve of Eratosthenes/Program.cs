using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveОfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool[] numbers = new bool[N+1];
            for (int i = 0; i <= N; i++)
            {
                numbers[i] = true;
            }
            numbers[0] = numbers[1] = false;

            for (int i = 2; i <= N; i++)
            {
                if (numbers[i])
                {
                    Console.Write(i + " ");

                    for (int k = 2; k <= N; k++)
                    {
                        int j = i * k;
                        if (j > N)
                        {
                            break;
                        }
                        numbers[j] = false;
                    }
                }
            }
        }
    }
}
