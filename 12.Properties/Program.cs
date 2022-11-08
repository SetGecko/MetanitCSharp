﻿Person tom = new("Tom");

// Ошибка - set объявлен с модификатором private
//tom.Name = "Bob";
Console.WriteLine(tom.Name);    // Tom
class Person
{
    string name = "";
    public string Name
    {
        get { return name; }

        private set { name = value; }
    }
    public Person(string name) => Name = name;
}