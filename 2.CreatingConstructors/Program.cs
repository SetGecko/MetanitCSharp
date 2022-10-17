Person zhuzha = new Person { name = "Zhuzha", age = 6, company = {title =  "Home" } };
// Person zhuzha = new Person { name = "Zhuzha", age = 6};
zhuzha.Print();
class Person
{
    public string name;
    public Company company;
    public int age;
    public Person()
    {
        name = "Undefined";
        company = new Company();
        age = 18;
    }

    public void Print() => Console.WriteLine($"Имя {name}, Возраст {age}, Компания {company.title}");

}

class Company
{
    public string title = "Unknown";
}