Console.WriteLine("\t\tОперации присваивания");
Console.WriteLine("----------");
int a = 40;
int b = 5;
b += a; // 45
Console.WriteLine($"Присваивание после сложения. a=40 b=5");
Console.WriteLine($"(b += a) = {b}");
Console.WriteLine("----------");
int c = 15;
b -= c; // 30
Console.WriteLine($"Присваивание после вычитания. с=15 b=45");
Console.WriteLine($"(b -= с) = {b}");
Console.WriteLine("----------");
int d = 6;
c *= d; // 90
Console.WriteLine($"Присваивание после умножения. с=15 d=6");
Console.WriteLine($"(c *= d) = {c}");
Console.WriteLine("----------");
int e = 10;
c /= e; // 9
Console.WriteLine($"Присваивание после деления. с=90 e=10");
Console.WriteLine($"(c /= e) = {c}");
Console.WriteLine("----------");
int f = 4;
c %= f; // 1
Console.WriteLine($"Присваивание после деления по модулю. с=9 f=10");
Console.WriteLine($"(c %= f) = {c}");
Console.WriteLine("----------");
int g = 10;
int h = 3;
h &= g;
Console.WriteLine($"Присваивание после поразрядной конъюнкции. g=10 h=3");
Console.WriteLine($"(h &= g) = {h}");
Console.WriteLine("----------");
int i = 20;
int j = 30;
j |= i;
Console.WriteLine($"Присваивание после поразрядной дизъюнкции. i=20 j=30");
Console.WriteLine($"(j |= i) = {j}");
Console.WriteLine("----------");
int k = 20;
int l = 30;
l ^= k;
Console.WriteLine($"Присваивание после операции исключающего ИЛИ. k=20 l=30");
Console.WriteLine($"(l ^= k) = {l}");
Console.WriteLine("----------");
int m = 1000;
int n = 10;
m <<= n;
Console.WriteLine($"Присваивание после сдвига разрядов влево. m=1000 n=10");
Console.WriteLine($"(m <<= n) = {m}");
Console.WriteLine("----------");
int o = 10;
int p = 1000;
p >>= o;
Console.WriteLine($"Присваивание после сдвига разрядов влево. o=1000 p=10");
Console.WriteLine($"(p >>= o) = {p}");
Console.WriteLine("----------");