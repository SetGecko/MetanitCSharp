PrintUpper(null);
PrintUpper("Жужа");

void PrintUpper(string? text)
{
    if (text is string)
    {
        Console.WriteLine(text.ToUpper());
    }
    else
    {
        Console.WriteLine("NULL");
    }
}