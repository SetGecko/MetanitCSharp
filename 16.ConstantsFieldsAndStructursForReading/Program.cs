Person tom = new Person();
tom.name = "Tom";
tom.Print();

Console.WriteLine(Person.type);



class Person
{
    public const string type = "Person";
    public string name = "Undefined";
    public void Print()
    {
        Console.WriteLine($"{type}: {name}");
    }
}