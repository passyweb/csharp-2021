using System;
using Chap03_Constructeurs.Models;
using static System.Console;

namespace Chap03_Constructeurs
{
    class Program
    {
        static void Main(string[] args)
        {
            // var rect = new Rectangle(1, 6);

            // (float width, float height) = rect;
            // WriteLine($"Width: {width}, Height:{height}");
            // WriteLine($" Rect => Width: {rect.Width}, Height:{rect.Height}");

            var person = new Person("Joel");

            WriteLine($"Son est {person.Name} et il {person.Age} ans");
        }
    }
}
