DayTime now = DayTime.Evening;

PrintMessage(now);                  // Добрый вечер
PrintMessage(DayTime.Afternoon);    // Добрый день
PrintMessage(DayTime.Night);        // Доброй ночи

void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning:
            Console.WriteLine("Доброе утро");
            break;
        case DayTime.Afternoon:
            Console.WriteLine("Добрый день");
            break;
        case DayTime.Evening:
            Console.WriteLine("Добрый вечер");
            break;
        case DayTime.Night:
            Console.WriteLine("Доброй ночи");
            break;
    }
}

enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}

// Console.WriteLine();




enum Operation
{
    Add,
    Substract,
    Multiply,
    Divide
}