using System;

namespace TodoList.Logic
{
    public class TodoItem
    {
        public TodoItem(int id, string task, bool isCompleted)
        {
            Id = id;
            Task = task;
            IsCompleted = isCompleted;
        }

        public TodoItem(string task, bool isCompleted)
        {
            Task = task;
            IsCompleted = IsCompleted;
        }

        public int Id { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            var complete = !IsCompleted ? "Actif" : "Fini";
            return $"Id:{Id}, Tache:{Task}, Etat:{complete}";
        }
    }
}
