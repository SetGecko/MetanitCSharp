PrintUpper(null);
PrintUpper("Жужа");

void PrintUpper(string? text)
{
    if (text is not null);
    {
        Console.WriteLine(text.ToUpper());
    }
}