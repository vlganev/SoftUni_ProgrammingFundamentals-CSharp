using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pokePowerN = decimal.Parse(Console.ReadLine());
            decimal distanceM = decimal.Parse(Console.ReadLine());
            byte exhaustionFactorY = byte.Parse(Console.ReadLine());
            decimal currentPokePower = pokePowerN;
            decimal halfPokePower = pokePowerN / 2;
            int count = 0;
            for (int i = 0; i >= 0; i++)
            {
                if (currentPokePower == halfPokePower && exhaustionFactorY != 0)
                {
                    currentPokePower = decimal.Truncate(currentPokePower / exhaustionFactorY);
                    continue;
                }
                currentPokePower = currentPokePower - distanceM;
                count++;
                if (currentPokePower < distanceM)
                {
                    break;
                }
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(count);
        }
    }
}
