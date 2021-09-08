using Microsoft.EntityFrameworkCore;
using TodoList.Logic;

namespace TodoList.ConsoleUI.Data
{
    public class TodoListContext : DbContext
    {
        private readonly string connectionString;

        public DbSet<TodoItem> TodoItems { get; set;}
        public DbSet<TodoList.Logic.TodoList> TodoLists { get; set; }

        public TodoListContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString);
        }
    }
}