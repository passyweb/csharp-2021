using System.Collections.Generic;
using TodoList.Logic;
using MySql.Data.MySqlClient;
using TodoList.ConsoleUI.Data;
using static System.Console;
using System.Linq;

namespace TodoList.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Server=localhost;Database=todo;
                Uid=root;Pwd=;";

            var controller = new EfController(connectionString);

            // controller.AddTodoItem(2, "club de lecture");
            // controller.AddTodoItem(2, "visiter zanzibar");
            // controller.AddTodoItem(2, "voir les chutes de la lofoi");
            // controller.AddTodoItem(3, "apprendre le mandarin");
            // controller.AddTodoItem(3, "visiter le grand canyon");
            // controller.AddTodoItem(1, "visiter les chutes wagenia");
            // controller.AddTodoItem(3, "escalader l'everest");

            controller.GetTodoListById(2);







            // var todoList = new TodoList.Logic.TodoList("Veronique");

            // todoList.AddTodoItem("apprendre le chinois");
            // todoList.AddTodoItem("se mettre au sport");

            // Affiche(todoList.Username, todoList.TodoItems);

            // todoList.MarkComplete(1, true);
            // Affiche(todoList.Username, todoList.TodoItems);
        }

        private static void Affiche(
            string username,
            List<TodoItem> items)
        {
            WriteLine($"TODO List de {username}");
            foreach (var item in items)
            {
                WriteLine(item);
            }
        }
    }
}
