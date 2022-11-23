using static System.Console;
using static Operation;

WriteLine(Sum(5, 4));
WriteLine(Subtract(5, 4));
WriteLine(Multiply(5, 4));

static class Operation
{
    public static int Sum(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}