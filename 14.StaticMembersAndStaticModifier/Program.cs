﻿Console.WriteLine(Operations.Add(5, 4));         // 9
Console.WriteLine(Operations.Subtract(5, 4));    // 1
Console.WriteLine(Operations.Multiply(5, 4));    // 20

static class Operations
{
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;

}