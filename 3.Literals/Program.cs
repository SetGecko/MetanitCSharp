Console.WriteLine("\tЛогические литералы");
Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine("\tЦелочисленные литералы");
Console.WriteLine(10);
Console.WriteLine(-109);
Console.WriteLine(56);
Console.WriteLine("---");

Console.WriteLine("Числа в двоичной форме предваряются символами 0b, после которых идет набор из нулей и единиц"); 
Console.WriteLine(0b11);
Console.WriteLine(0b1011);
Console.WriteLine(0b100001);
Console.WriteLine("---");

Console.WriteLine("Для записи числа в шестнадцатеричной форме применяются символы 0x, после которых идет набор символов от 0 до 9 и от A до F");
Console.WriteLine(0x0A);
Console.WriteLine(0xFF);
Console.WriteLine(0xA1);
Console.WriteLine("---");

Console.WriteLine("Вещественные литералы");
Console.WriteLine(3.14);
Console.WriteLine(100.001);
Console.WriteLine(-0.38);
Console.WriteLine(3.2e3);   // по сути равно 3.2 * 10<sup>3</sup> = 3200
Console.WriteLine(1.2E-1);  // равно 1.2 * 10<sup>-1</sup> = 0.12
Console.WriteLine("---");

Console.WriteLine("Символьные литералы");
Console.WriteLine('A');
Console.WriteLine('2');
Console.WriteLine('t');
/*
Специальную группу представляют управляющие последовательности 
Управляющая последовательность представляет символ, перед которым ставится слеш.
И данная последовательность интерпретируется определенным образом. 
Наиболее часто используемые последовательности:
\n - перевод строки
\t - табуляция
\\ - слеш
*/
Console.WriteLine("---");

Console.WriteLine("Шестнадцатеричные коды ASCII");
Console.WriteLine('\x78');    // x
Console.WriteLine('\x5A');    // Z
Console.WriteLine("---");

Console.WriteLine("Таблица символов Unicode");
Console.WriteLine('\u0420');    // Р
Console.WriteLine('\u0421');    // С
Console.WriteLine("---");

Console.WriteLine("Строковые литералы");
Console.WriteLine("hello");
Console.WriteLine("фыва");
Console.WriteLine("world");
Console.WriteLine("Компания \"Рога и копыта\"");
Console.WriteLine("Привет \n\t\tмир");

//  Console.WriteLine();
//  Console.ReadKey();