using Microsoft.EntityFrameworkCore;

namespace LibraryManagement
{
    public class LibraryContext : DbContext
    {
        private readonly string _connectionString;

        public LibraryContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Book> Books { get; set;}
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            optionsBuilder.UseMySQL(_connectionString);
        }
    }
}