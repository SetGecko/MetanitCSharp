namespace Base;

class Person
{
    string name;
    public Person(string name) => this.name = name;
    public void Print() => Console.WriteLine($"Имя: {name} ");
}