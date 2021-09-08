using static System.Console;

namespace Chap03_Heritage
{
    public class Person 
    {
        public string Name {get; set;}

        public Person(string name) => Name = name;

        public virtual void DonneStatut() => Write($"Je suis {Name}");
    }
}