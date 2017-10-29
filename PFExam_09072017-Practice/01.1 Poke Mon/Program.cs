using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            long pokePowerN = long.Parse(Console.ReadLine());
            long distanceM = long.Parse(Console.ReadLine());
            byte exhaustionFactorY = byte.Parse(Console.ReadLine());
            long currentPokePower = pokePowerN;
            int count = 0;
            long halfPokePower = pokePowerN / 2;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (currentPokePower >= distanceM)
            {
                if (currentPokePower == halfPokePower && exhaustionFactorY != 0)
                {
                    currentPokePower = currentPokePower / exhaustionFactorY;
                    continue;
                }
                currentPokePower -= distanceM;
                count++;
            }
            stopwatch.Stop();
 //           Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine(currentPokePower);
            Console.WriteLine(count);
        }
    }
}
