/*
Console.WriteLine("Введите имя: ");
string name = Console.ReadLine();

switch (name)
{
    case "Жужа":
        Console.WriteLine("Даааа, этоо жужааа");
        break;
    case "Tom":
        Console.WriteLine("Ваше имя Tom");
        break;
    case "Bob":
        Console.WriteLine("Ваше имя Bob");
        break;
    default:
        Console.WriteLine("неизвестное имя");
        break;
}
*/

int DoOperation (int op, int a, int b)
{
    switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        default: return 0;
    }
}

int result1 = DoOperation(1, 2, 3); // 5
Console.WriteLine(result1);

int result2 = DoOperation(2, 6, 3); // 3
Console.WriteLine (result2);

int result3 = DoOperation(3, 1, 7); // 7
Console.WriteLine (result3);
