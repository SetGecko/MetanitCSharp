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
    public Person(string name = "Неизвестно", int age = 18)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}