Console.WriteLine("\tСравнения  if...else if...else");
Console.WriteLine("-----");
Console.Write("Введите первое число: ");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
var num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}"); 
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}
else
{
    Console.WriteLine("Оба введённые числа равны");
}


Console.Write("Введите имя котейки:");
string? petName = Console.ReadLine();

if (petName == "Жужа" || petName == "жужа")
{
    Console.WriteLine("У вас самая сладкая котейка!");
}
else
{
    Console.WriteLine($"Вашу котейку зовут {petName}");
}

Console.WriteLine("\n-----");
Console.WriteLine("\tТернарные операции");
Console.WriteLine("-----");
Console.WriteLine("\n[первый операнд - условие] ? [второй операнд] : [третий операнд]");
int x = 3;
int y = 2;
int z = x < y ? (x + y) : (x - y);
Console.WriteLine("x = 3\ny = 2\nz = x < y ? (x + y) : (x - y)");
Console.WriteLine(z);