/*
Упражнение 1
Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. 
А программа сранивает два введенных числа и выводит на консоль результат сравнения 
(два числа равны, первое число больше второго или первое число меньше второго).
 */

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