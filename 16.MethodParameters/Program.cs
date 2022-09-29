Console.WriteLine("Метод с входным параметром string");
Console.WriteLine("-----");

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage("Привет Жужа");
PrintMessage("Няняня");
PrintMessage("Кошки любят вкусняшки");
Console.WriteLine("-----\n");

Console.WriteLine("Метод для сложения чисел");
Console.WriteLine("-----");

void Sum(int x, int y)
{
    int result = x + y;
    Console.WriteLine($"Сумма {x} и {y} = {result}");
}

Sum(2, 2);
Sum(3, 7);
Sum(8, 8);
int a = 55;
int b = 45;
Sum(a, b);
Console.WriteLine("-----\n");

Console.WriteLine("Необязательные параметры");
Console.WriteLine("-----");

void PrintPerson(string name, int age = 1, string company = "Undefinied")
{
    Console.WriteLine($"Имя: {name}  Возраст: {age}  Компания: {company}");
}

PrintPerson("Tom", 25, "Google");
PrintPerson("Lee", 37);
PrintPerson("Jerry");

// Именованные параметры

PrintPerson(name:"Жужа", age: 4, company: "Домашняя котя");

