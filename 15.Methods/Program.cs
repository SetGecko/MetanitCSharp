void SayHelloRu()
{
    Console.WriteLine("Привет");
}

void SayHelloEn()
{
    Console.WriteLine("Hello");
}

void SayHelloFr()
{
    Console.WriteLine("Salut");
}

string language = "fr";

switch (language)
{
    case "en":
        SayHelloEn();
        break;
    case "ru":
        SayHelloRu();
        break;
    case "fr":
        SayHelloFr();
        break;
}

// Сокращённая запись методов

void Bububu() => Console.WriteLine("Bububu");

Bububu();