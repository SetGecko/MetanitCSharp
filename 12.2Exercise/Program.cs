Console.WriteLine("Введите сумму вклада: ");
decimal summ = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите количество месяцев для хранения вклада: ");
int monthAmount = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < (monthAmount + 1))
{
    summ = summ + (summ * 0.07M);
    Console.WriteLine($"В {i} месяц сумма по вкладам с процентами равна {summ}");
    i++;
}
