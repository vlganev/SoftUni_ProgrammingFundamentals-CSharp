using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeter = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeInSeconds = (hours * 60.0f + minutes)*60.0f + seconds;
            float speedMeterPerSecond = distanceMeter / timeInSeconds;
            float timeInHours = hours + minutes / 60.0f + seconds / 3600.0f;
            float speedKilometersPerHour = distanceMeter / 1000.0f / timeInHours;
            float speedMilesPerHours = distanceMeter / 1609.0f / timeInHours;
            Console.WriteLine(speedMeterPerSecond);
            Console.WriteLine(speedKilometersPerHour);
            Console.WriteLine(speedMilesPerHours);
        }
    }
}
