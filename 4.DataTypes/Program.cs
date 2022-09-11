Console.WriteLine("\tЛогические литералы - System.Boolean");
Console.WriteLine("-----");
bool alive = true;
bool isDead = false;
Console.WriteLine($"Значение булевой переменной alive = {alive}");
Console.WriteLine($"Значение булевой переменной isDead = {isDead}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tbyte - целое число от 0 до 255 - System.Byte");
Console.WriteLine("-----");
byte bit1 = 1;
byte bit2 = 102;
Console.WriteLine($"Значение byte переменной bit1 = {bit1}");
Console.WriteLine($"Значение byte переменной bit2 = {bit2}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tsbyte - целое число от -128 до 127 - System.SByte");
Console.WriteLine("-----");
sbyte bit3 = -101;
sbyte bit4 = 102;
Console.WriteLine($"Значение sbyte переменной bit3 = {bit3}");
Console.WriteLine($"Значение sbyte переменной bit4 = {bit4}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tshort - целое число от -32768 до 32767 - System.Int16");
Console.WriteLine("-----");
short n1 = 1;
short n2 = 102;
Console.WriteLine($"Значение short переменной n1 = {n1}");
Console.WriteLine($"Значение short переменной n2 = {n2}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tushort - целое число от 0 до 65535 - System.UInt16");
Console.WriteLine("-----");
ushort n3 = 1;
ushort n4 = 102;
Console.WriteLine($"Значение ushort переменной  = {n3}");
Console.WriteLine($"Значение ushort переменной  = {n4}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tint - целое число от -2 147 483 648 до 2 147 483 647 - System.Int32");
Console.WriteLine("-----");
int a = 10;
int b = 0b101;  // бинарная форма b =5
int c = 0xFF;   // шестнадцатеричная форма c = 255
Console.WriteLine($"Значение int переменной  = {a}");
Console.WriteLine($"Значение int переменной (в бинарной форме b=0b101) = {b}");
Console.WriteLine($"Значение int переменной (в шестнадцатеричной форме c=0xFF) = {c}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tuint - целое число от 0 до 4 294 967 295 - System.UInt32");
Console.WriteLine("-----");
uint d = 10;
uint e = 0b101;
uint f = 0xFF;
Console.WriteLine($"Значение uint переменной d = {d}");
Console.WriteLine($"Значение uint переменной (в бинарной форме e=0b101) = {e}");
Console.WriteLine($"Значение uint переменной (в шестнадцатеричной форме f=0xFF) = {f}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tlong - целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 - System.Int64");
Console.WriteLine("-----");
long g = -10;
long h = 0b100;
long i = 0xF;
Console.WriteLine($"Значение long переменной g = {g}");
Console.WriteLine($"Значение long переменной (в бинарной форме h=0b10) = {h}");
Console.WriteLine($"Значение long переменной (в шестнадцатеричной форме i=0xF) = {i}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tulong - целое число от 0 до 18 446 744 073 709 551 615 - System.UInt64");
Console.WriteLine("-----");
ulong j = 1001;
ulong k = 9646513;
ulong l = 46546519684;
Console.WriteLine($"Значение ulong переменной j = {j}");
Console.WriteLine($"Значение ulong переменной k = {k}");
Console.WriteLine($"Значение ulong переменной l = {l}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tfloat - число с плавающей точкой от -3.4*10(38) до 3.4*10(38) - System.Single");
Console.WriteLine("-----");
float m = 10.5F;
float n = 0.42F;
Console.WriteLine($"Значение float переменной m = {m}");
Console.WriteLine($"Значение float переменной n = {n}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tdouble - число с плавающей точкой от ±5.0*10(-324) до ±1.7*10(308) - System.Double");
Console.WriteLine("-----");
double o = 123.56;
double p = 17.23;
Console.WriteLine($"Значение double переменной o = {o}");
Console.WriteLine($"Значение double переменной p = {p}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tdecimal - десятичное дробное число, может хранить 28 знаков после запятой - System.Decimal");
Console.WriteLine("-----");
decimal q = 1.2352641M;
decimal r = 5.1232533673743M;
Console.WriteLine($"Значение decimal переменной q = {q}");
Console.WriteLine($"Значение decimal переменной r = {r}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tchar - одиночный символ в кодировке Unicode - System.Char");
Console.WriteLine("-----");
char s = 'A';
char t = '\x5A';
char u = '\u0420';
Console.WriteLine($"Значение char переменной s = {s}");
Console.WriteLine($"Значение char переменной t = {t}");
Console.WriteLine($"Значение char переменной u = {u}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tstring - набор символов Unicode - System.String");
Console.WriteLine("-----");
string hello = "Hello";
string word = "world";
Console.WriteLine($"Значение string переменной hello = {hello}");
Console.WriteLine($"Значение string переменной word = {word}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tobject - значение любого типа данных - System.Object");
Console.WriteLine("-----");
object a3 = 22;
object b3 = 3.14;
object c3 = "hello code";
Console.WriteLine($"Значение object переменной a3 = {a3}");
Console.WriteLine($"Значение object переменной b3 = {b3}");
Console.WriteLine($"Значение object переменной c3 = {c3}");
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine("\tНеявная типизация");
Console.WriteLine("-----");
var zz = 12;
var worddd = "bzzzzzz";
Console.WriteLine($"Неявно типитизированная переменная zz имеет тип Int и равна {zz}");
Console.WriteLine($"Неявно типитизированная переменная worddd имеет тип String и равна {worddd}");
Console.WriteLine("-----");
Console.WriteLine();

string name = "Tom";
int age = 33;
bool isEmployed = false;
double weight = 78.65;
Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age} года");
Console.WriteLine($"Трудозанятый? {isEmployed}");
Console.WriteLine($"Вес: {weight}");


/*
Console.WriteLine("\t");
Console.WriteLine($"Значение  переменной  = {}");
Console.WriteLine($"Значение  переменной  = {}");
Console.WriteLine("-----");
Console.WriteLine();
Console.WriteLine("-----");
Console.WriteLine();
*/