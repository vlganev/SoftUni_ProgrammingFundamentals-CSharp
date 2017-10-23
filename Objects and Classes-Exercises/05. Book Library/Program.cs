using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            
            Library ourLibrary = new Library();
            ourLibrary.BookList = new List<Books>();

            for (int i = 0; i < inputLines; i++)
            {
                string[] bookInput = Console
                    .ReadLine()
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

            foreach (var pair in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
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
