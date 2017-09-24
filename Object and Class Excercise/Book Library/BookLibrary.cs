using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime Releasedate { get; set; }
    public int Isbn { get; set; }
    public double Price { get; set; }

    public Book(string Title, string Author, string Publisher, DateTime Releasedate, int Isbn, double price)
    {
        this.Title = Title;
        this.Author = Author;
        this.Publisher = Publisher;
        this.Releasedate = Releasedate;
        this.Isbn = Isbn;
        this.Price = price;
    }

}
class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

class AuthorsInfo
{
    public string Author { get; set; }

    public double Sales { get; set; }
}
class BookLibrary
{
    static void Main()
    {
        var libraly = new Library()
        {
            Name = "Znanie",
            Books = new List<Book>()
        };
        var countReadBook = int.Parse(Console.ReadLine());
        for (int i = 0; i < countReadBook; i++)
        {
            var readInput = Console.ReadLine().Split(' ');

            var title = readInput[0];
            var author = readInput[1];
            var publisher = readInput[2];
            var releaseDate = DateTime.ParseExact(readInput[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var Isbn = int.Parse(readInput[4]);
            var price = double.Parse(readInput[5]);

            var book = new Book(title, author, publisher, releaseDate, Isbn, price);
            libraly.Books.Add(book);       
        }

        var authorSale = libraly.Books.Select(a => a.Author).Distinct().Select(a => new AuthorsInfo
        {
            Author = a,
            Sales = libraly.Books.Where(x => x.Author == a).Sum(b => b.Price)
        }).OrderByDescending(s => s.Sales).ThenBy(a => a.Author).ToArray();

        foreach (var item in authorSale)
        {
            Console.WriteLine($"{item.Author} -> {item.Sales:f2}");
        }

    }
    //private static Dictionary<string, double> ReadBook(int n)
    //{
    //    Library library = new Library();
    //    Dictionary<string, double> priceAuthor = new Dictionary<string, double>();
    //    for (int i = 0; i < n; i++)
    //    {
    //        string[] bookDate = Console.ReadLine().Split(' ');
    //        var tittle = bookDate[0];
    //        var author = bookDate[1];
    //        var publisher = bookDate[2];
    //        var releaseDate = bookDate[3];
    //        var ISBNNumber = bookDate[4];
    //        var price = double.Parse(bookDate[5]);

    //        AllBook(author, price, priceAuthor);

    //        library.Name = author;
    //        // library.Books =
    //    }
    //    return priceAuthor;
    //}
    //private static void AllBook(string author, double price, Dictionary<string, double> authorAndPrice)
    //{
    //    Stack<string> stack = new Stack<string>();
    //    stack.Push(author);
    //    double sumPrice = 0.0;
    //    if (!authorAndPrice.ContainsKey(author))
    //    {
    //        authorAndPrice.Add(author, price);

    //    }
    //    else
    //    {
    //        foreach (var prices in stack)
    //        {
    //            var lastElement = authorAndPrice[prices];

    //            sumPrice = lastElement + price;
    //            break;
    //        }


    //        authorAndPrice[author] = sumPrice;
    //    }
}

