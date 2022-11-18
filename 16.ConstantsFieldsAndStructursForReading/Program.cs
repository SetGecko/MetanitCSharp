readonly struct Person
{
    public readonly string Name { get; } // указывать readonly необязательно
    public int Age { get; } // свойство только для чтения
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}