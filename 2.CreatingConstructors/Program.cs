Person tom = new Person();
Person bob = new Person("Bob");
Person sam = new Person("Sam", 25);

tom.Print();
bob.Print();
sam.Print();

class Person
{
    public string name;
    public int age;
    public Person() { name = "неизвестно"; age = 18; }
    public Person(string n) { name = n; age = 18; }
    public Person(string n, int a) { name = n; age = a; }

    public void Print()
    {
        Console.WriteLine($"Имя {name}, возраст {age}");
    }
}