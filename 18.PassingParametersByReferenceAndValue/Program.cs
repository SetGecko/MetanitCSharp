// Передача параметров по значению
void Increment(int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

int number = 5;
Console.WriteLine($"Число до метода Increment: {number}");
Increment(number);
Console.WriteLine($"Число после метода Increment: {number}");
Console.WriteLine($"-----------\n\n");

// Передача параметров по ссылке и модификатор ref
void Increment2(ref int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

int number2 = 5;
Console.WriteLine($"Число до метода Increment: {number2}");
Increment2(ref number2);
Console.WriteLine($"Число после метода Increment: {number2}");
Console.WriteLine($"-----------\n\n");

// Выходные параметры. Модификатор out
void Sum(int x, int y, out int result2)
{
    result2 = x + y;
}

int number3;

Sum(10, 15, out number3);

Console.WriteLine(number3);
Console.WriteLine($"-----------\n\n");

void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
{
    rectArea = width * height;
    rectPerimetr = (width + height) * 2;
}

GetRectangleData(10, 20, out int area, out int perimetr);

Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60
Console.WriteLine($"-----------\n\n");

// Входные параметры. Модификатор in
void GetRectangleData2(in int width, in int height, out int rectArea, out int rectPerimetr)
{
    //width = 25; // нельзя изменить, так как width - входной параметр
    rectArea = width * height;
    rectPerimetr = (width + height) * 2;
}

int w = 10;
int h = 20;
GetRectangleData2(w, h, out var area2, out var perimetr2);

Console.WriteLine($"Площадь прямоугольника: {area2}");       // 200
Console.WriteLine($"Периметр прямоугольника: {perimetr2}");   // 60