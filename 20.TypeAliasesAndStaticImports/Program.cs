using printer = System.Console;
using User = Person;

User tom = new User("Tom");
printer.WriteLine(tom.Name);


class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;
}