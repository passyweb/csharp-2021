using System;
using static System.Console;

namespace Chapitre02
{
    class Program
    {
        static void Main(string[] args)
        {
            Panda p1 = Panda.Create(""); //new Panda("");

            WriteLine(p1.Name);
            WriteLine(Panda.Population);
        }
    }

    class Panda 
    {
        public string Name ;
        public static int Population = 0;

        private Panda(string name)
        {
            Name = name;
            Population++;
        }

        public static Panda Create(string name)
        {
            //// check

            return new Panda(name);
        }
    }
}
