﻿object person1 = new Employee("Tom", "Microsoft");  // от Employee к object
object person2 = new Client("Bob", "ContosoBank");  // от Client к object
object person3 = new Person("Sam");                 // от Person к object

class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"Person {Name}");
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}

class Client : Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}