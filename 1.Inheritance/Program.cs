Person person = new Person("Bob");
person.Print();     // Bob
Employee employee = new Employee("Tom", "Microsoft");
employee.Print();   // Tom

class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine(Name);
    }
}

class Employee : Person
{
    public string Company { get; set; } = "";
    public Employee(string name, string company)
        :base(name)
    {
        Company = company;
    }
}