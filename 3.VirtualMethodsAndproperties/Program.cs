Person bob = new Person("Bob");
Console.WriteLine(bob.Age); // 1

Employee tom = new Employee("Tom", "Microsoft");
Console.WriteLine(tom.Age); // 18
tom.Age = 22;
Console.WriteLine(tom.Age); // 22
tom.Age = 12;
Console.WriteLine(tom.Age); // 22

class Person
{
    int age = 1;
    public virtual int Age
    {
        get => age;
        set { if (value > 0 && value < 110) age = value; }
    }
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public virtual void Print() => Console.WriteLine(Name);
}
class Employee : Person
{
    public string Company { get; set; }

    public Employee(string name, string company)
                : base(name)
    {
        Company = company;
    }

    public override sealed void Print()
    {
        Console.WriteLine($"{Name} работает в {Company}");
    }
}