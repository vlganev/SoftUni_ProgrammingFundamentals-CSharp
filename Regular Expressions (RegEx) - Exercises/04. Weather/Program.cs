using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})(\d{0,2}.\d{0,2})([a-zA-Z]+)\|";
            Regex regex = new Regex(pattern);
            SortedDictionary<string, SortedDictionary<double, string>> weather = new SortedDictionary<string, SortedDictionary<double, string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                Match match = regex.Match(input);
                string city = match.Groups[1].ToString();
                string words = match.Groups[3].ToString();

                if (city != "" && words != "")
                {
                    double temp = double.Parse(match.Groups[2].ToString());
                    SortedDictionary<double, string> weatherInfo = new SortedDictionary<double, string>();
                    weatherInfo.Add(temp, words);
                    if (weather.ContainsKey(city))
                    {
                        weather.Remove(city);
                    }
                    weather.Add(city, weatherInfo);
                }
            }

            foreach (var city in weather.OrderBy(kvp => kvp.Value.Sum(y => y.Key)))
            {
                foreach (var weatherInfo in weather[city.Key])
                {
                    string country = city.Key;
                    double temp = weatherInfo.Key;
                    string words = weatherInfo.Value;
                    Console.WriteLine($"{country} => {temp:f2} => {words}" );
                }
            }
        }
    }
}
