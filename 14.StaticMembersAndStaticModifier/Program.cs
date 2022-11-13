Person Tom = new Person(69);
Tom.CheckAge();

Person Bob = new Person(35);
Bob.CheckAge();

class Person
{
    int age;
    public static int retirementAge = 65;
    public Person (int age)
    {
        this.age = age;
    }

    public void CheckAge()
    {
        if (age > retirementAge)
            Console.WriteLine("Уже на пенсии");
        else
            Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
    }
}