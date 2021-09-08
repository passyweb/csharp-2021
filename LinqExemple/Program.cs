using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace LinqExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("Jacques", 25),
                new Student("Darius", 50),
                new Student("Ange", 30),
                new Student("Bruce", 14),
                new Student("Rita", 23),
                new Student("Grace", 15)
            };
    

            var query = students
                            .Where(a => a.Age > 20)
                            // .Skip(2)
                            // .Take(1)
                            .Select(a => new 
                            {
                                Nom = a.Name,
                                AgeSportif = a.Age - 5
                            });
            foreach (var item in query)
            {
                WriteLine($"{item.Nom} - {item.AgeSportif}");
            }
        }

        static void Linq()
        {
                        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var query = from num in numbers
                        where (num % 2) != 0
                        orderby num descending
                        select num;
            foreach (var item in query)
            {
                Write(item);
                Write(" ");
            } 
            WriteLine();
            WriteLine($"Premier item {query.First()}");  
            WriteLine($"Sum {query.Sum()}");  
            WriteLine($"Max {query.Max()}");  
            WriteLine($"Min {query.Min()}");  
            WriteLine($"Count {query.Count()}");  
            WriteLine($"Average {query.Average()}");
        }
    }
}
