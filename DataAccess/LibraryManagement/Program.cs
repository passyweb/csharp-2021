using System;
using LibraryManagement.Controllers;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=localhost;Database=library;
                Uid=root;Pwd=;";
            var context = new LibraryContext(connectionString);
            context.Database.EnsureCreated();

            var publisherController = new PublisherController(context);          
            publisherController.AddNewPublisher("Albin Michel");
            //publisherController.GetPublishers();

            var bookController = new BookController(context);
            bookController.AddBook("Les compagnons de Jehu", "Alexandre Dumas", "Français", 1056, 2);
            bookController.GetBooks();
        }
    }
}
