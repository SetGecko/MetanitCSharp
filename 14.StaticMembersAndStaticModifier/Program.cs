﻿Console.WriteLine(Person.RetirementAge);

class Person
{
    static int retirementAge;
    public static int RetirementAge => retirementAge;
    static Person()
    {
        if (DateTime.Now.Year == 2022)
            retirementAge = 65;
        else
            retirementAge = 67;
    }
}