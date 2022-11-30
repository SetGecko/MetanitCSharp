// Объект Employee также представляет тип object
object obj = new Employee("Bill", "Microsoft");

// чтобы обратиться к возможностям типа Employee, приводим объект к типу Employee
Employee employee = (Employee)obj;

// объект Client также представляет тип Person
Person person = new Client("Sam", "ContosoBank");
// преобразование от типа Person к Client
Client client = (Client)person;

class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"Person {Name}");
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}

class Client : Person
{
    public string Bank { get; set; }
    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}