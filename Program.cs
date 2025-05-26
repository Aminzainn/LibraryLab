using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using Azure;
using LibraryLab.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LibraryLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryDbContext Context = new LibraryDbContext();

            //1.Insert a single object (e.g., Author or Member).
            //Author one = new Author() { Name = "Amin" };
            //Context.Authors.Add(one);
            //Context.SaveChanges();

            //var AutorsDetailes = Context.Authors.Select(a => a);
            //foreach (var item in AutorsDetailes)
            //{
            //    Console.WriteLine("Autor Id : " + item.Id + " ,And his name is : " + item.Name);
            //}

            //2.Insert a list of objects (e.g., multiple Books).

            //List<Book> book = new List<Book>
            //    {
            //    new Book{ Title="harry potter",AuthorId=1,PublishedYear=null},
            //    new Book{Title="Game Of Thrones",AuthorId=2,PublishedYear=2001},
            //    new Book{Title="One Piece",AuthorId=1,PublishedYear=2005}
            //    };

            //for (int i = 0; i < book.Count; i++)
            //{
            //    Context.Books.Add(book[i]);
            //}
            //Context.SaveChanges();

            //var booksdetailes = Context.Books.Select(b => b);
            //foreach(var item in booksdetailes)
            //{
            //    Console.WriteLine("book Id : " + item.Id + " ,And its title is : " + item.Title + " ,its PublishedYear is : " + item.PublishedYear);

            //}

            //3.Insert using navigation properties (e.g., Book with its Author).
            //Author newAuthor = new Author
            //{
            //    Name = "George Orwell"
            //};

            //Book newBook = new Book
            //{
            //    Title = "1984",
            //    PublishedYear = 1949,
            //    Author = newAuthor 
            //};
            //Context.Books.Add(newBook);
            //Context.SaveChanges();
            //Console.WriteLine("A book was added");

            //4.Update objects (e.g., change Book title or Member name).

            //Book updatedBook = new Book
            //{
            //    Id = 2, 
            //    Title = "New Book Title",
            //    PublishedYear = 2003,
            //    AuthorId = 1 
            //};

            //Context.Books.Update(updatedBook);
            //Context.SaveChanges();
            //Console.WriteLine("the book was updated");

            //5.Use EntityState to manipulate object states.

            //Author detachedAuthor = new Author
            //{
            //    Id = 1, 
            //    Name = "new Author Name"
            //};

            //Context.Entry(detachedAuthor).State = EntityState.Modified;
            //Context.SaveChanges();
            //Console.WriteLine("updated succefully.");

            //6.Delete a list of objects (e.g., all Books by an Author).

            //var booksByAuthor = Context.Books.Where(b => b.AuthorId == 1).ToList();

            //foreach (var book in booksByAuthor)
            //{
            //    Context.Books.Remove(book);
            //}

            //Context.SaveChanges();
            //Console.WriteLine("all books deleted");

            //7.Try eager loading and lazy loading(compare performance).

            //var stopwatch = new Stopwatch();

            //// Eager Loading
            //stopwatch.Start();
            //var eagerBooks = Context.Books
            //    .Include(b => b.Author)
            //    .ToList();
            //foreach (var book in eagerBooks)
            //{
            //    var name = book.Author?.Name;
            //}
            //stopwatch.Stop();
            //Console.WriteLine($"Eager Loading Time: {stopwatch.ElapsedMilliseconds} ms");

            //stopwatch.Reset();

            //// Lazy Loading
            //stopwatch.Start();
            //var lazyBooks = Context.Books.ToList();
            //foreach (var book in lazyBooks)
            //{
            //    var name = book.Author?.Name;
            //}
            //stopwatch.Stop();
            //Console.WriteLine($"Lazy Loading Time: {stopwatch.ElapsedMilliseconds} ms");

            //Console.WriteLine();

            //if (eagerBooks.Count == lazyBooks.Count)
            //{
            //    Console.WriteLine("Result: " +
            //        (stopwatch.ElapsedMilliseconds > 100
            //        ? "Eager Loading is faster"
            //        : "Lazy Loading is acceptable in this case "));
            //}

            //بعد قياس وقت كل عمليه نقدر نقول ان مش بالضروره يكون في طريقه احسن من التانيه
            //و لكن علي حسب انت حتستخدمه ازاي و ليه


            //<<<<<<<<<bouns>>>>>>>>>>>>>
            //1.Use AsNoTracking for read - only performance optimization.
            //var authors = Context.Authors.AsNoTracking().ToList();

            //foreach (var author in authors)
            //{
            //    Console.WriteLine($"Author Id: {author.Id}, Name: {author.Name}");
            //}



            //2. Use Attach to update objects without retrieving them first.
            //var book = new Book { Id = 1 }; 
            //Context.Books.Attach(book);     
            //book.Title = "Updated Title";   
            //Context.SaveChanges();          
            //Console.WriteLine("Book title updated using Attach.");


            //3.Use stored procedures (GetBookByAuthorId).

            //int authorId = 1;
            //var books = Context.Books
            //    .FromSqlRaw("EXEC GetBookByAuthorId @p0", authorId)
            //    .ToList();

            //foreach (var book in books)
            //{
            //    Console.WriteLine($"Book Id: {book.Id}, Title: {book.Title}");
            //}


            Console.ReadKey();

        }
    }
}
