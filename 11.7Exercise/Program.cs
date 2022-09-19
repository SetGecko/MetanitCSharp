/*
Упражнение 7
Измените предыдущую программу. 
Пусть пользователь кроме номера операции вводит два числа, 
и в зависимости от номера операции с введенными числами выполняются определенные действия 
(например, при вводе числа 3 числа умножаются). 
Результа операции выводиться на консоль.
 */

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер операции: \n1.Сложение \n2.Вычитание \n3.Умножение \n");
int operation = Convert.ToInt32(Console.ReadLine());

int result = 0;

switch (operation)
{
    case 1:
        result = num1 + num2;
        Console.WriteLine($"Результатом сложения {num1} и {num2} равно {result}");
        break;
    case 2:
        result = num1 - num2;
        Console.WriteLine($"Результатом разности из {num1} и {num2} равно {result}");
        break;
    case 3:
        result = num1 * num2;
        Console.WriteLine($"Результатом произведения из {num1} и {num2} равно {result}");
        break;
    default:
        Console.WriteLine("Операция не определена");
        break;
}