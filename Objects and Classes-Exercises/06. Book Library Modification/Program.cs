using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            Library ourLibrary = new Library();
            ourLibrary.BookList = new List<Books>();
            DateTime givenDate = new DateTime();
            for (int i = 0; i <= inputLines; i++)
            {
                if (i == inputLines)
                {
                    givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    break;
                }
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

            foreach (Books book in ourLibrary.BookList.Where(x => x.ReleaseDate > givenDate).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
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
