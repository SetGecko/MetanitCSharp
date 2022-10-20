Person tom;

tom.name = "Tom";
tom.age = 40;

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