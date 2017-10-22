using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
