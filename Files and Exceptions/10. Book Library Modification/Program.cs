using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");
            var number = Directory.GetFiles(".")
                .Where(f => f.StartsWith(".\\output"))
                .Select(f => f.Split('_').Skip(1).FirstOrDefault())
                .Where(f => f != null)
                .Select(f => f.Replace(".txt", ""))
                .Select(int.Parse)
                .ToList();

            int nextNumber = 0;
            if (number.Any())
            {
                nextNumber = number.Max() + 1;
            }
            var outputFileName = "output_" + nextNumber + ".txt";

            var library = new Library
            {
                Name = "Prosvete",
                Books = new List<Book>()
            };
            //var bookCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines.Length; i++)
            {
                var tokens = lines[i].Split();
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
                var output = $"{pair.Key} -> {pair.Value:dd.MM.yyyy}" + Environment.NewLine;
                File.AppendAllText(outputFileName, output);
            }
        }
    }
 
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
