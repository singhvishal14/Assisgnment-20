using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssisgnment_20
{
    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>()
            {
                new Book() { BookId = 1, Title = "Head first c#", Author = "Andrew Stellman", Genre = "2007", IsAvailable = true },
                new Book() { BookId = 2, Title = "Concurrency in C#", Author = "Stephen Cleary", Genre = "2014", IsAvailable = true },
                new Book() { BookId = 3, Title = "Pro .Net 2.0", Author = "Matthew MacDonald", Genre = "2005", IsAvailable = true },
                new Book() { BookId = 4, Title = "Programming C# 5.0", Author = "Ian Griffiths", Genre = "2012", IsAvailable = true },
                new Book() { BookId = 5, Title = "C# 6.0 and the .NET 4.6 Framework", Author = "Andrew Troelsen", Genre = "2015", IsAvailable = true }
            };
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ViewAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void SearchBookById(int bookId)
        {
            var book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void SearchBookByTitle(string title)
        {
            var book = books.Find(b => b.Title.ToLower() == title.ToLower());
            if (book != null)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
