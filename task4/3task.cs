using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{Title} ({Author}, {Year})";
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        return books.Where(b => b.Author == author).ToList();
    }

    public List<Book> SearchByYear(int year)
    {
        return books.Where(b => b.Year == year).ToList();
    }

    public void SortByTitle()
    {
        books = books.OrderBy(b => b.Title).ToList();
    }

    public void PrintBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        library.AddBook(new Book { Title = "Book1", Author = "Author1", Year = 2000 });
        library.AddBook(new Book { Title = "Book2", Author = "Author2", Year = 2005 });
        library.AddBook(new Book { Title = "Book3", Author = "Author1", Year = 2010 });

        library.PrintBooks();

        Console.WriteLine("Books by Author1:");
        var booksByAuthor1 = library.SearchByAuthor("Author1");
        foreach (var book in booksByAuthor1)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("Books from 2005:");
        var booksFrom2005 = library.SearchByYear(2005);
        foreach (var book in booksFrom2005)
        {
            Console.WriteLine(book);
        }

        library.SortByTitle();
        Console.WriteLine("Sorted by title:");
        library.PrintBooks();
    }
}
