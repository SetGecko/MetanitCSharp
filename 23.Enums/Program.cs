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
Console.WriteLine("----");

DoOperation(10, 5, Operation.Add);          // 15
DoOperation(10, 5, Operation.Substract);     // 5
DoOperation(10, 5, Operation.Multiply);     // 50
DoOperation(10, 5, Operation.Divide);       // 2
Console.WriteLine("----");
void DoOperation (double x, double y, Operation op)
{
    double result = op switch
    {
        Operation.Add => x + y,
        Operation.Substract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y,
    };
    Console.WriteLine(result);

}

DayTime now2 = DayTime.Morning;

Console.WriteLine((int)now2);  // 0
Console.WriteLine((int)DayTime.Night); // 3



enum Time: byte
{
    Morning,
    Afternoon,
    Evening,
    Night
}
enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}


enum Operation
{
    Add,
    Substract,
    Multiply,
    Divide
}