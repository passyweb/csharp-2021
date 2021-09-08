using MySql.Data.MySqlClient;
using Dapper;
using static System.Console;

namespace TodoList.ConsoleUI
{
    public class DapperMenu
    {
        private MySqlConnection _connection;

        public DapperMenu(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
        }

        public void AddTodoList(string username)
        {
            _connection.Query(@"INSERT INTO todolists(Username) 
            VALUES(@Username)",
                new {
                    Username = username
                });
        }

        public void GetTodoLists()
        {
            var todolists = _connection
                .Query<TodoList.Logic.TodoList>("SELECT * FROM todolists");
            foreach (var item in todolists)
            {
                WriteLine($"{item.Id}--{item.Username}");
            }
        }
    }
}