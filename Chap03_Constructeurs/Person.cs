namespace Chap03_Constructeurs.Models
{
    public class Person 
    {
        public string Name 
        {
            get;
            set;
        }

        private int age;
        public int Age
        {
            get 
            {
                if(age < 15) return 0;
                return age;
            }
            set 
            {
                if(value < 15) age = 20;
                else age = value;
            }
        }

        public Person() => Age = 15;

        public Person(string name)
            : this() => Name = name;

        public Person(string name, int age) 
            : this(name)
        {
            Age = age;
        }
    }
}