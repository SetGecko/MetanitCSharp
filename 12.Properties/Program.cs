﻿Person tom = new();

Console.WriteLine(tom.Name);    // Tom
Console.WriteLine(tom.Age);    // 37

class Person
{
    public string Name { get; set; } = "Tom";
    public int Age { get; set; } = 37;
}