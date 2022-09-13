Console.WriteLine("\t\t|---Арифметические операции---|");
Console.WriteLine("-----");

Console.WriteLine("\tСложение");
Console.WriteLine("-----");
int a = 20;
int b = 17;
int c = a + b;
Console.WriteLine($"Сумма: (а={a}) + (b={b}) = {c}");
Console.WriteLine("-----");
Console.WriteLine("");

Console.WriteLine("\tРазность");
Console.WriteLine("-----");
int d = 29;
int e = 11;
int f = d - e;
Console.WriteLine($"Разность: (d={d}) - (e={e}) = {f}");
Console.WriteLine("-----");
Console.WriteLine("");

Console.WriteLine("\tУмножение");
Console.WriteLine("-----");
int g = 11;
int h = 7;
int i = g * h;
Console.WriteLine($"Произведение: (g={g}) * (h={h}) = {i}");
Console.WriteLine("-----");
Console.WriteLine("");

Console.WriteLine("\tДеление - целочисленное");
Console.WriteLine("-----");
int j = 20;
int k = 4;
int l = j / k;
Console.WriteLine($"Частное: (j={j}) / (k={k}) = {l}");
Console.WriteLine("-----");
Console.WriteLine("");

Console.WriteLine("\tДеление - чисел с плавающей точкой");
Console.WriteLine("-----");
double m = 10;
double n = 3;
double o = m / n;
Console.WriteLine($"Частное: (m={m}) / (n={n}) = {o}");
Console.WriteLine("-----");
Console.WriteLine("");

Console.WriteLine("\tДеление - чисел без плавающей точки");
Console.WriteLine("-----");
double p = 10.0;
double q = 4.0;
double r = p / q;
Console.WriteLine($"Частное: (p=10.0) / (q=4.0) = {r}");
Console.WriteLine("-----");
Console.WriteLine("");

Console.WriteLine("\tДеление - остаток целочисленного");
Console.WriteLine("-----");
double s = p % q;
Console.WriteLine($"Целочисленое частное: (p=10.0) % (q=4.0) = {s}");
Console.WriteLine("-----");
Console.WriteLine("");

Console.WriteLine("\tОперация инкремента");
Console.WriteLine("-----");
Console.WriteLine("Операция префиксного инкремента");
int x1 = 5;
int z1 = ++x1; // z1=6; x1=6
Console.WriteLine($"x1 = {x1} - (z1 = ++x1) = {z1}");
Console.WriteLine("Операция постфиксного инкремента");
int x2 = 5;
int z2 = x2++; // z2=5; x2=6
Console.WriteLine($"x2 = {x2} - (z2 = x2++) = {z2}");
Console.WriteLine("-----");
Console.WriteLine("");

Console.WriteLine("\tОперация инкремента");
Console.WriteLine("-----");
Console.WriteLine("Операция префиксного декремента");
int x3 = 5;
int z3 = --x3; // z3=4; x3=4
Console.WriteLine($"x3 = {x3} - (z3 = --x3){z3}");
Console.WriteLine("Операция постфиксного декремента");
int x4 = 5;
int z4 = x4--; // z4=5; x4=4
Console.WriteLine($"x4 = {x4} - (z4 = x4--) = {z4}");
Console.WriteLine("-----");
Console.WriteLine("");