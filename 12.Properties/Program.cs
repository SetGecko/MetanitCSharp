﻿Person person = new();
//person.Name = "Bob";    //! Ошибка - после инициализации изменить значение нельзя

Console.WriteLine(person.Name); // Undefined
public class Person
{
    public string Name { get; init; } = "Undefined";
}