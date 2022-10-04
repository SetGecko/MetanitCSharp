// Нахождение факториала рекурсивной функцией
int Factorial(int n)
{
    if (n == 0)
        return 1;
    else
        return n * Factorial(n - 1);
}
int x = 5;
Console.WriteLine(Factorial(x));
Console.WriteLine(Factorial(4));
Console.WriteLine(Factorial(7));
Console.WriteLine("--------------------------");

int Fibonachi(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;
    else
        return Fibonachi(n - 1) + Fibonachi(n - 2);
}

Console.WriteLine(Fibonachi(4));
Console.WriteLine(Fibonachi(6));
Console.WriteLine(Fibonachi(8));