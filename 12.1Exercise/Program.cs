using System.ComponentModel.DataAnnotations;

Console.WriteLine("Введите сумму вклада: ");
decimal summ = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите количество месяцев для хранения вклада: ");
int monthAmount = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < (monthAmount + 1); i++)
{
    summ = summ + (summ * 0.07M);
    Console.WriteLine($"В {i} месяц сумма по вкладам с процентами равна {summ}");
}