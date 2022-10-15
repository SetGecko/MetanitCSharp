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