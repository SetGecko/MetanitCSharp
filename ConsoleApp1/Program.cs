Console.WriteLine("Hello, World!");
Console.WriteLine("-----");

Console.Write("Введите своё имя: ");
string? name = Console.ReadLine();
Console.WriteLine($"Привет {name}");
//string? - значит что переменная может быть null

Console.ReadKey();