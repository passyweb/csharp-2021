using System.Text;

namespace LibraryManagement
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public Publisher Publisher { get; set; }

        public override string ToString()
        {
            var data = new StringBuilder();
            data.AppendLine($"Title: {Title}");
            data.AppendLine($"Author: {Author}");
            data.AppendLine($"Language: {Language}");
            data.AppendLine($"Pages: {Pages}");
            return data.ToString();
        }
    }
}