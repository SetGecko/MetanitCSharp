﻿Person person = new Person();

Console.WriteLine(person.Age);  // 1
// изменяем значение свойства
person.Age = 37;
Console.WriteLine(person.Age);  // 37
// пробуем передать недопустимое значение
person.Age = -23;               // Возраст должен быть в диапазоне от 1 до 120
Console.WriteLine(person.Age);  // 37 - возраст не изменился

class Person
{
    int age = 1;
    public int Age
    {
        set
        {
            if (value < 1 || value > 120)
                Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
            else
                age = value;
        }
        get { return age; }
    } 
}