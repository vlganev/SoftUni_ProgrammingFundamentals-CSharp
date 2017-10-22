using System;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            double healthPointsPesho = 100;
            double healthPointsGosho = 100;

            int round = 0;

            while (healthPointsGosho > 0 && healthPointsPesho > 0)
            {
                round++;
                if (round %2 == 1)
                {
                    healthPointsGosho -= peshoDamage;
                    if (healthPointsGosho > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthPointsGosho} health.");
                        if (round % 3 == 0)
                        {
                            healthPointsPesho += 10;
                            healthPointsGosho += 10;
                        }
                    }
                }
                else
                {
                    healthPointsPesho -= goshoDamage;
                    if (healthPointsPesho > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPointsPesho} health.");
                        if (round % 3 == 0)
                        {
                            healthPointsPesho += 10;
                            healthPointsGosho += 10;
                        }
                    }
                }

            }
            if (healthPointsPesho <= 0)
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
            else if (healthPointsGosho <= 0)
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }
        }
    }
}
