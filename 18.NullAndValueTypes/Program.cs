int? number = null; // если значения нет, метод возвращает значение по умолчанию
Console.WriteLine(number.GetValueOrDefault());      // 0  - значение по умолчанию для числовых типов
Console.WriteLine(number.GetValueOrDefault(10));    // 10

number = 15;    // если значение задано, оно возвращается методом
Console.WriteLine(number.GetValueOrDefault());    // 15
Console.WriteLine(number.GetValueOrDefault(10));  // 15


void PrintNullable(int? number)
{
    if(number.HasValue)
    {
        Console.WriteLine(number.Value);
    }
    else
    {
        Console.WriteLine("Параметр равен null");
    }
}