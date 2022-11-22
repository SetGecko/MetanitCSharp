PrintUpper(null);
PrintUpper("Жужа");

void PrintUpper(string? text)
{
    if(text!=null)
    {
        Console.WriteLine(text.ToUpper());
    }
}