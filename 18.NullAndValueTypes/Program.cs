// явное преобразование от T? к T
int? x1 = null;
if(x1.HasValue)
{
    int x2 = (int)x1;
    Console.WriteLine(x2);
}

// неявное преобразование от T к T?
int x3 = 4;
int? x4 = x3;
Console.WriteLine(x4);

// неявные расширяющие преобразования от V к T?

int x5 = 4;
long? x6 = x5;
Console.WriteLine(x6);

// явные сужающие преобразования от V к T?
long x7 = 4;
int? x8 = (int)x7; // это аналогично:

long? x9 = 4;
int? x10 = (int)x9;

// явные сужающие преобразования от V? к T
long? x11 = null;
if(x11.HasValue)
{
    int x12 = (int)x11;
}
