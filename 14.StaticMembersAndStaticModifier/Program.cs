﻿Person bob = new(68);
bob.СheckAge();

Console.WriteLine(Person.RetirementAge); // 65

class Person
{
    int age;
    static int retirementAge = 65;
    public static int RetirementAge
    {
        get { return retirementAge; }
        set { if (value > 1 && value < 100) retirementAge = value; }
    }
    public Person(int age)
    {
        this.age = age;
    }
    public void СheckAge()
    {
        if (age >= retirementAge)
            Console.WriteLine("Уже на пенсии");
        else
            Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
    }
}