using System.Linq;
using LibraryManagement.Exceptions;
using static System.Console;

namespace LibraryManagement.Controllers
{
    public class PublisherController
    {
        private readonly LibraryContext _context;

        public PublisherController(LibraryContext context)
        {
            _context = context;
        }

        public void AddNewPublisher(string name)
        {
            var publisher = new Publisher
            {
                Name = name
            };
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public void UpdatePublisher(int id, string name)
        {
            var publisher = _context.Publishers.Find(id);
            if(publisher == null) 
            {
                throw new NotFoundException(nameof(Publisher), id);
            }
            publisher.Name = name;
            _context.SaveChanges();
        }

        public void GetPublishers()
        {
            var publishers = _context.Publishers
                .OrderBy(publisher => publisher.Name)
                .ToList();
            
            foreach (var item in publishers)
            {
                WriteLine(item);
            }
        }
    }
}