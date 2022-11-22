using System;

void PrintWebSite(Person? person)
{
    Console.WriteLine(person?.Company?.WebSite?.ToUpper());
}

// или

void PrintWebSite(Person? person)
{
    if (person != null && person.Company != null && person.Company.WebSite != null)
    {
        Console.WriteLine(person.Company.WebSite.ToUpper());
    }
}

class Person
{
    public Company? Company { get; set; }   // место работы
}
class Company
{
    public string? WebSite { get; set; }    // веб-сайт компании
}