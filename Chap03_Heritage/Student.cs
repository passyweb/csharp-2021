using static System.Console;

namespace Chap03_Heritage
{
    public class Student : Person
    {
        public Student(string name) : base(name) 
        {}

        public override void DonneStatut()
        {
            base.DonneStatut();
            WriteLine($" et je suis etudiant");
        }
    }
}