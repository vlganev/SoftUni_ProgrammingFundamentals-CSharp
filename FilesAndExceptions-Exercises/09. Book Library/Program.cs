using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library ourLibrary = new Library();
            ourLibrary.BookList = new List<Books>();
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
                    int inputLines = int.Parse(line);
                    for (int i = 0; i < inputLines; i++)
                    {
                        line = reader.ReadLine();
                        string[] bookInput = line
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                        string title = bookInput[0];
                        string author = bookInput[1];
                        string publisher = bookInput[2];
                        DateTime releaseDate = DateTime.ParseExact(bookInput[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        string isbn = bookInput[4];
                        double price = double.Parse(bookInput[5]);

                        Books book = new Books
                        {
                            Title = title,
                            Author = author,
                            Publisher = publisher,
                            ReleaseDate = releaseDate,
                            ISBN = isbn,
                            Price = price
                        };
                        ourLibrary.BookList.Add(book);
                    }

                    Dictionary<string, double> authors = new Dictionary<string, double>();
                    foreach (Books book in ourLibrary.BookList)
                    {
                        if (authors.ContainsKey(book.Author))
                        {
                            authors[book.Author] += book.Price;
                        }
                        else
                        {
                            authors[book.Author] = book.Price;
                        }
                    }
                    using (StreamWriter writer = new StreamWriter(path + "output.txt", append: true))
                    {
                        foreach (var pair in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                        {
                            writer.WriteLine($"{pair.Key} -> {pair.Value:f2}");
                        }
                    }
                }
            }
        }
    }

    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Books> BookList { get; set; }
        public void AddBook(Books book)
        {
            BookList.Add(book);
        }
    }
}
