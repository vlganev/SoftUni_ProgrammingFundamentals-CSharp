using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> populationCounter = new Dictionary<string, Dictionary<string, decimal>>();

            bool canContinue = true;
            while (canContinue)
            {
                string input = Console.ReadLine();
                if (input == "report")
                {
                    canContinue = false;
                    break;
                }

                string[] inputLine = input.Split('|');
                string city = inputLine[0];
                string country = inputLine[1];
                decimal population = decimal.Parse(inputLine[2]);

                if (populationCounter.ContainsKey(country))
                {
                    if (populationCounter[country].ContainsKey(city))
                    {
                        populationCounter[country][city] += population;
                    }
                    else
                    {
                        populationCounter[country].Add(city, population);
                    }
                }
                else
                {
                    populationCounter.Add(country, new Dictionary<string, decimal> { { city, population } });
                }
            }

            foreach (var countryCityPeople in populationCounter.OrderByDescending(kvp => kvp.Value.Sum(y => y.Value)))
            {
                var country = countryCityPeople.Key;
                Console.WriteLine(country + " (total population: {0})", populationCounter[country].Values.Sum());
                foreach (var cityPeople in populationCounter[country].OrderByDescending(p => p.Value))
                {
                    var city = cityPeople.Key;
                    var people = cityPeople.Value;

                    Console.WriteLine($"=>{city}: {people}");
                }
            }
        }
    }
}
