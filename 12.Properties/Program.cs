﻿Person tom = new("Tom", "Smith");
Console.WriteLine(tom.Name);    // Tom Smith
class Person
{
    string firstName;
    string lastName;
    public string Name
    {
        get { return $"{firstName} {lastName}"; }
    }
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}