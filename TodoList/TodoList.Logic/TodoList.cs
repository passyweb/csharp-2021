using System.Collections.Generic;
using System.Linq;

namespace TodoList.Logic
{
    public class TodoList
    {
        private int nextId = 1;

        public TodoList() 
        {
            TodoItems = new List<TodoItem>();
        }

        public TodoList(string username) : this()
        {
            Username = username;
        }

        public string Username { get; set; }
        public int Id { get; set; }
        public List<TodoItem> TodoItems { get; set; }

        public int AddTodoItem(string task)
        {
            while(GetTodoItemById(nextId) != null)
            {
                nextId++;
            }

            var item = new TodoItem(nextId, task, false);
            TodoItems.Add(item);
            return nextId;
        }

        public TodoItem GetTodoItemById(int nextId) => TodoItems
                .SingleOrDefault(a => a.Id == nextId);

        public void MarkComplete(int id, bool complete)
        {
            var item = GetTodoItemById(id);
            if (item != null)
                item.IsCompleted = complete;
        }

        public List<TodoItem> GetTodoItems(bool includeComplete) 
        {
            return TodoItems
                .Where(item => includeComplete || !item.IsCompleted)
                .ToList();
        }

        public void RemoveComplete()
        {
            var items = TodoItems
                .Where(item => item.IsCompleted)
                .ToList();
            foreach (var item in items)
            {
                TodoItems.Remove(item);               
            }
        }
    }
}