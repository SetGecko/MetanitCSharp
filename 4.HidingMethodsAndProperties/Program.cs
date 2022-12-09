Console.WriteLine(Person.minAge);     // 1
Console.WriteLine(Person.typeName);   // Person

Console.WriteLine(Employee.minAge);     // 18
Console.WriteLine(Employee.typeName);   // Employee

class Person
{
    public readonly static int minAge = 1;
    public const string typeName = "Person";
}
class Employee : Person
{
    // скрываем поля и константы базового класса
    public new readonly static int minAge = 18;
    public new const string typeName = "Employee";
}