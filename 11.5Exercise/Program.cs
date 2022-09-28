﻿/*
Упражнение 5
Изменим предыдущую задачу. 
Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц 
вне зависимости от их суммы. 
Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.
*/

Console.Write("Введите сумму вклада: ");
var num1 = Convert.ToDouble(Console.ReadLine());

if (num1 < 100)
{
    num1 = (num1 + (num1 * 0.05)) + 15;
    Console.WriteLine($"Сумма вклада с процентами составляет: {num1}");
}
else if (num1 >= 100 & num1 <= 200)
{
    num1 = (num1 + (num1 * 0.07)) + 15;
    Console.WriteLine($"Сумма вклада с процентами составляет: {num1}");
}
else if (num1 > 200)
{
    num1 = (num1 + (num1 * 0.10)) + 15;
    Console.WriteLine($"Сумма вклада с процентами составляет: {num1}");
}