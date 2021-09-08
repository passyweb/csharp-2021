using System;
using System.Linq;
using static System.Console;

namespace LibraryManagement.Controllers
{
    public class BookController 
    {
        private readonly LibraryContext _context;

        public BookController(LibraryContext context)
        {
            _context = context;
        }

        public void AddBook(string title, string author, string language, int pages, int publisherId)
        {
            var publisher = _context.Publishers.Find(publisherId);
            if(publisher == null) 
            {
                throw new NullReferenceException();
            }
            var book = new Book
            {
                Title = title,
                Author = author,
                Language = language,
                Pages = pages,
                Publisher = publisher
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void GetBooks()
        {
            var books = _context.Books.ToList();
            foreach (var item in books)
            {
                WriteLine(item);
            }
        }
    }
}