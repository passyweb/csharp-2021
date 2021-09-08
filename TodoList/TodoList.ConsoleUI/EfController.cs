using TodoList.ConsoleUI.Data;
using System.Linq;
using static System.Console;
using TodoList.Logic;
using Microsoft.EntityFrameworkCore;

namespace TodoList.ConsoleUI
{
    public class EfController
    {
        private readonly TodoListContext _context;

        public EfController(string connectionString)
        {
            _context = new TodoListContext(connectionString);
        }

        public void GetTodoLists()
        {
            var query = from t in _context.TodoLists
                        select t;
            foreach (var item in query)
            {
                WriteLine($"{item.Id}--{item.Username}");
            }
        }

        public void AddTodoList(string username)
        {
            var obj = new TodoList.Logic.TodoList("Joseph");
            _context.TodoLists.Add(obj);
            _context.SaveChanges();
        }

        public void UpdateTodoList(int id, string username)
        {
            var todolist = _context.TodoLists
                .Find(id);
            todolist.Username = username;
            _context.SaveChanges();
        }

        public void AddTodoItem(int todoListId, string task)
        {
            var todolist = _context.TodoLists
                .Find(todoListId);
            var item = new TodoItem(task, false);
            todolist.TodoItems.Add(item);
            _context.SaveChanges();
        }

        public void GetTodoListById(int id)
        {
            var query = _context.TodoLists
                            .Include(list => list.TodoItems)
                            .Where(a => a.Id == id);

            var queryString = query.ToQueryString();
            WriteLine(queryString);
            var list = query.First();
            
            WriteLine($"{list.Id}--{list.Username}");
            foreach (var item in list.TodoItems)
            {
                WriteLine(item);
            }
        }
    }
}