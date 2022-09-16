Console.WriteLine("\t\tУсловные выражения");
Console.WriteLine("-----");
Console.WriteLine("\tОперации сравнения");

Console.WriteLine("==");
int a = 10;
int b = 4;
bool c = a == b; // false
Console.WriteLine(c);
Console.WriteLine();

Console.WriteLine("!=");
int a1 = 10;
int b1 = 4;
bool c1 = a1 != b1;    // true
bool d1 = a1 != 10;     // false
Console.WriteLine(c1);
Console.WriteLine(d1);
Console.WriteLine();

Console.WriteLine("<");
int a2 = 10;
int b2 = 4;
bool c2 = a2 < b2; // false
Console.WriteLine(c2);
Console.WriteLine();

Console.WriteLine(">");
int a3 = 10;
int b3 = 4;
bool c3 = a3 > b3;     // true
bool d3 = a3 > 25;
Console.WriteLine(c3);
Console.WriteLine(d3);
Console.WriteLine();

Console.WriteLine("<=");
int a4 = 10;
int b4 = 4;
bool c4 = a4 <= b4;     // false
bool d4 = a4 <= 25;    // true
Console.WriteLine(c4);
Console.WriteLine(d4);
Console.WriteLine();

Console.WriteLine(">=");
int a5 = 10;
int b5 = 4;
bool c5 = a5 >= b5;     // true
bool d5 = a5 >= 25;    // false
Console.WriteLine(c5);
Console.WriteLine(d5);
Console.WriteLine();
Console.WriteLine("-----");

Console.WriteLine("\tОперации сравнения");
Console.WriteLine("| Возвращает true, если хотя бы один из операндов возвращает true.");
bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
Console.WriteLine(x1);
Console.WriteLine(x2);
Console.WriteLine();

Console.WriteLine("& Возвращает true, если оба операнда одновременно равны true.");
bool x3 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
bool x4 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
Console.WriteLine(x3);
Console.WriteLine(x4);
Console.WriteLine();

Console.WriteLine("|| Возвращает true, если хотя бы один из операндов возвращает true.");
bool x5 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
bool x6 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
Console.WriteLine(x5);
Console.WriteLine(x6);
Console.WriteLine();

Console.WriteLine("&& Возвращает true, если оба операнда одновременно равны true");
bool x7 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
bool x8 = (5 < 6) && (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
Console.WriteLine(x7);
Console.WriteLine(x8);
Console.WriteLine();

Console.WriteLine("! Производится над одним операндом и возвращает true, если операнд равен false. Если операнд равен true, то операция возвращает false");
bool a6 = true;
bool b6 = !a6;    // false
Console.WriteLine(b6);
Console.WriteLine();

Console.WriteLine("^ озвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, иначе возвращает false");
bool x9 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
bool x99 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false
Console.WriteLine(x9);
Console.WriteLine(x99);
Console.WriteLine();