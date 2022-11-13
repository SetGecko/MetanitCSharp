﻿var tom = new Person();
var bob = new Person();
var sam = new Person();
Console.WriteLine(Person.Counter);  // 3

class Person
{
    static int counter = 0;
    public static int Counter => counter;
    public Person()
    {
        counter++;
    }
}