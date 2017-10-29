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
            List<string> listWeather = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                Match match = regex.Match(input);
                string city = match.Groups[1].ToString();
                string temp = match.Groups[2].ToString().PadRight(5, '0');
                string words = match.Groups[3].ToString();

                if (city != "" && temp != "" && words != "")
                {
                    if (listWeather.Any(l => l.Contains(city)))
                    {
                        int index = listWeather.FindIndex(l => l.Contains(city));
                        listWeather.RemoveAt(index);
                    }
                    string result = city + " => " + temp + " => " + words;
                    listWeather.Add(result);
                }
            }
            for (int i = 0; i < listWeather.Count; i++)
            {
                Console.WriteLine(listWeather[i]);
            }
        }
    }
}