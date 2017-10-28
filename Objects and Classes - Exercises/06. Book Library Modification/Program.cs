using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library
            {
                Name = "Prosvete",
                Books = new List<Book>()
            };
            var bookCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < bookCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                var title = tokens[0];
                var author = tokens[1];
                var publisher = tokens[2];
                var releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = tokens[4];
                var price = decimal.Parse(tokens[5]);

                var book = new Book(title, author, publisher, releaseDate, isbn, price);
                library.Books.Add(book);

            }
            var dateAfter = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            //var titles = library.Books.Select(a => a.Title).ToArray();
            var titleDate = new Dictionary<string, DateTime>();

            foreach (Book book in library.Books)
            {
                if (book.ReleaseDate > dateAfter)
                {
                    titleDate.Add(book.Title, book.ReleaseDate);
                }
            }
            foreach (var pair in titleDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", pair.Key, pair.Value);
            }
        }
    }
    //class TitleInfo
    //{
    //    public string Title { get; set; }
    //    public DateTime Date { get; set; }
    //}
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
    }
}
