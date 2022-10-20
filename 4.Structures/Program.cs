Person tom = new Person();

tom.name = "Tom";
tom.Print();

struct Person
{
    public string name;
    public int age;

    public void Print()
    {
        Console.WriteLine($"Имя: {name}, возраст: {age}");
    }
}