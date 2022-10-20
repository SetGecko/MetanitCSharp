Person tom = new Person { name = "Tom", age = 22 };

tom.Print();    // !!!! Имя:   Возраст: 0

struct Person
{
    public string name;
    public int age;
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}