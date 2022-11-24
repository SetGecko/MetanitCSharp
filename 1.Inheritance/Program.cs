﻿Person person = new Person { Name = "Tom" };
person.Print();   // Tom
person = new Employee { Name = "Sam" };
person.Print();   // Sam

class Person
{
    private string _name = "";

    public string Name
    {
        get { return _name;}
        set { _name = value; }
    }
    
    public void Print()
    {
        Console.WriteLine(Name);
    }
}

class Employee : Person
{

}