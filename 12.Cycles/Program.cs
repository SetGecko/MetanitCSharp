Console.WriteLine("\t\tЦиклы");
Console.WriteLine("--------\n");
Console.WriteLine("\n--------");
Console.WriteLine("For");
Console.WriteLine("--------");
for (int i = 1; i < 4; i++)
// for ([действия_до_выполнения_цикла]; [условие]; [действия_после_выполнения])
// До тех пока (i переменнная равна 1, выполнять цикл до тех пор пока i меньше 4, i++ 
// увеличивать за каждый проход цикла переменную i на 1)
{
    Console.WriteLine(i);
    // в каджом проходе цикла отобразить значение переменной i
}
// Можно записать цикл более коротко
for (int i = 1; i < 4; i++) Console.WriteLine($"Переменная i = {i}");

// Также стоит отметить, что можно определять несколько переменных в объявлении цикла:
for (int i = 1, j = 1; i < 10; i++, j++) Console.WriteLine($"{i * j}");

Console.WriteLine("\n--------");
Console.WriteLine("do..while");
Console.WriteLine("--------\n");
//В цикле do сначала выполняется код цикла,
//а потом происходит проверка условия в инструкции while.
//И пока это условие истинно, цикл повторяется.
//Но важно отметить, что цикл do гарантирует хотя бы единократное выполнение действий,
//даже если условие в инструкции while не будет истинно.
/*
 * 

do
{
    действия цикла
}
while (условие)

*/

int a = 6;
do
{
    Console.WriteLine(a);
    a--;
}
while (a > 0);

Console.WriteLine("\n--------");
Console.WriteLine("while");
Console.WriteLine("--------\n");

/*
 * В отличие от цикла do цикл while сразу проверяет истинность некоторого условия, 
 * и если условие истинно, то код цикла выполняется

 while (условие)
{
    действия цикла
}

*/

int b = 8;
while (b > 0)
{
    Console.WriteLine(b);
    b--;
}

Console.WriteLine("\n--------");
Console.WriteLine("foreach");
Console.WriteLine("--------\n");
/*
 * Цикл foreach предназначен для перебора набора или коллекции элементов.
 
foreach(тип_данных переменная in коллекция)
{
    // действия цикла
}

*/

foreach (char c in "Бурубулька")
{
    Console.WriteLine(c);
}
Console.WriteLine("\n\n");
// Если не сам не определил тип переменных можно использовать var
foreach (var c in "Жужулица")
{
    Console.WriteLine(c);
}

Console.WriteLine("\n--------");
Console.WriteLine("Операторы continue и break");
Console.WriteLine("--------\n");
/*
 * Иногда возникает ситуация, когда требуется выйти из цикла, 
 * не дожидаясь его завершения. В этом случае мы можем воспользоваться оператором break.
 */
for (int i = 0; i < 9; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);
}

// Хотя в условии цикла сказано, что цикл будет выполняться,
// пока счетчик i не достигнет значения 9, в реальности цикл сработает 5 раз.
// Так как при достижении счетчиком i значения 5, сработает оператор break, и цикл завершится.
Console.WriteLine("\n\n");
/*  А что если мы хотим, чтобы при проверке цикл не завершался, 
 *  а просто пропускал текущую итерацию. 
 *  Для этого мы можем воспользоваться оператором continue
 */

for (int i = 0; i < 9; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine(i);
}
Console.WriteLine("\n\n");
Console.WriteLine("\n--------");
Console.WriteLine("Вложенные циклы");
Console.WriteLine("--------\n");
// Одни циклы могут быть вложенными в другие.

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n\n");
for (int i = 1; i < 3; i++)
{
    for (int j = 1; j < 3; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}