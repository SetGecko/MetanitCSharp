PrintUpper(null);
PrintUpper("Жужа");

void PrintUpper(string? text)
{
    if (text is null) return;
    {
        Console.WriteLine(text.ToUpper());
    }
}