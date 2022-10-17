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
    public Person() { name = "Неизвестно"; age = 18; }
    public Person(string name) { this.name = name; age = 18; }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}