using System;
using static System.Console;


Person person = new();
person.Name = "Bavon";

WriteLine(person.Name);

class Person 
{
    public string Name;
}

