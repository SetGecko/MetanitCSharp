string GetMessage()
{
    return "bububu";
}

string message = GetMessage();
Console.WriteLine(message);

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage(GetMessage());

int Sum (int x, int y)
{
    return x + y;
}

int result = Sum(5, 6);
Console.WriteLine(result);

Console.WriteLine(Sum(10, 15));

void PrintPerson(string name, int age)
{
    if (age > 120 || age < 1)
    {
        Console.WriteLine("Недопустимый возраст");
        return;
    }
    Console.WriteLine($"Имя {name} Возраст {age}");
}

PrintPerson("Жужа", 4);
PrintPerson("Том", 1234);
