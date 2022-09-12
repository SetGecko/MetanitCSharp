Console.WriteLine("\tКонсольный вывод");
Console.WriteLine("------------");
string hello = "Привет мир";
Console.WriteLine(hello);
Console.WriteLine("Добро пожаловать в C#!");
Console.WriteLine("Пока мир...");
Console.WriteLine(24.5);
Console.WriteLine("------------");
string name = "Tom";
int age = 34;
double height = 1.7;
// Вывод информации путём интерполяции
Console.WriteLine($"Имя: {name}, возраст: {age}, рост: {height}м");
// Вывод информации используя "плейсхолдеры"
Console.WriteLine("Имя: {0}, возраст: {1}, рост: {2}м", name, age, height);
Console.WriteLine("------------");
Console.WriteLine("");

Console.WriteLine("\tConsole.Write");
Console.WriteLine("------------");
Console.Write($"Имя: {name}, возраст: {age}, рост: {height}м");
Console.WriteLine("");
Console.WriteLine("------------");
Console.WriteLine("");

Console.WriteLine("\tКонсольный ввод");
Console.WriteLine("------------");
Console.Write("Введите имя вашего питомца: ");
string? petName = Console.ReadLine();
Console.WriteLine($"Имя вашего питомца: {petName}");
Console.WriteLine("------------");
Console.WriteLine("");
Console.WriteLine("------------");

Console.Write("Введите имя: ");
string? name2 = Console.ReadLine();
Console.Write("Введите возраст: ");
int age2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите рост: ");
double height2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Имя: {name2} \nВозраст: {age2} \nРост: {height2} \nЗарплата: {salary}$");