using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {num2}");
            Console.WriteLine($"b = {num1}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");

        }
    }
}
