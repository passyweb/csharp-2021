using System.Collections.Generic;

namespace LibraryManagement
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return $"{Id} -- {Name}";
        }
    }
}