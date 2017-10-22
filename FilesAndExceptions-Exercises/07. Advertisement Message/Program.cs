using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\";
            if (File.Exists(path + "output.txt"))
                File.Delete(path + "output.txt");

            using (StreamReader reader = new StreamReader(path + "input.txt", Encoding.GetEncoding("UTF-8")))
            {
                string line = "x";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line)) break;
                    int lines = int.Parse(line);
                    string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
                    string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
                    string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
                    string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

                    Random randomNumber = new Random();

                    using (StreamWriter writer = new StreamWriter(path + "output.txt", append: true))
                    {
                        writer.WriteLine($"Count: {lines}");

                        for (int i = 0; i < lines; i++)
                        {
                            string phrase = phrases[randomNumber.Next(phrases.Length)];
                            string theEvent = events[randomNumber.Next(events.Length)];
                            string author = authors[randomNumber.Next(authors.Length)];
                            string city = cities[randomNumber.Next(cities.Length)];

                            writer.WriteLine($"{phrase} {theEvent} {author} – {city}.");
                        }
                    }
                }
            }
        }
    }
}
