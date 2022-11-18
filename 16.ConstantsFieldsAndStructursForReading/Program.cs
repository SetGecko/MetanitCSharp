Person tom = new Person("Tom");
Console.WriteLine(tom.name);



class Person
{
    public readonly string name = "Undefined";
    public Person(string name)
    {
        this.name = name;
    }
    public void  ChangeName(string otherName)
    {

    }
}