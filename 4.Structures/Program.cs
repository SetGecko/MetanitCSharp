Person tom = new Person();

tom.Print();

struct Person
{
    public string name = "Tom";
    public int age = 40;
    public Person() { }
    public void Print()
    {
        Console.WriteLine($"Имя: {name}, возраст: {age}");
    }
}