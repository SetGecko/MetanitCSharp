﻿Person bob = new Person(68);
Person.CheckRetirementStatus(bob);

class Person
{
    public int Age { get; set; }
    static int retirementAge = 65;
    public Person(int age) => Age = age;
    public static void CheckRetirementStatus(Person person)
    {
        if (person.Age >= retirementAge)
            Console.WriteLine("Уже на пенсии");
        else
            Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - person.Age}");
    }
}