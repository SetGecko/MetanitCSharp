Person person = new Person("Tom", 33);
(string name, int age) = person;

Console.WriteLine(name);    // Tom
Console.WriteLine(age);     // 33

class Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
}






