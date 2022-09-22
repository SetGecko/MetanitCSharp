// Создание мсассива
int[] nums = new int[] { 1, 2, 3, 5 };
string[] people = { "Tom", "Sam", "Bob" };

//Индексы и получение элементов массива
// получение значения 3 элемента массива
Console.WriteLine(nums[3]);

// получение элемента массива в переменную
var n = nums[1];     // 2
Console.WriteLine(n);

// изменим второй элемент массива
nums[1] = 505;

Console.WriteLine(nums[1]);  // 505

// получим длину  созданного массива nums
Console.WriteLine(nums.Length);

// Получение элементов с конца массива
Console.WriteLine(nums[nums.Length - 1]);  // 5 - первый с конца или последний элемент
Console.WriteLine(nums[nums.Length - 2]);  // 3 - второй с конца или предпоследний элемент
Console.WriteLine(nums[nums.Length - 3]);  // 505 - третий элемент с конца

// специальный оператор ^, с помощью которого можно задать индекс относительно конца коллекции
Console.WriteLine(nums[^1]);  // 5 - первый с конца или последний элемент
Console.WriteLine(nums[^2]);  // 3 - второй с конца или предпоследний элемент
Console.WriteLine(nums[^3]);  // 505 - третий элемент с конца

// Перебор массивов
foreach (int i in nums)
{
    Console.WriteLine(i);
}

// Если foreach последовательно извлекает элементы контейнера и только для чтения,
// то в цикле for мы можем перескакивать на несколько элементов вперед в зависимости
// от приращения счетчика, а также можем изменять элементы
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = nums[i] * 2;
    Console.WriteLine(nums[i]);
}


int[,] nums2 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };

foreach (int i in nums2)
    Console.Write($"{i} ");

int rows = nums2.GetUpperBound(0) + 1;    // количество строк
int columns = nums2.Length / rows;        // количество столбцов
                                          // или так
                                          // int columns = numbers.GetUpperBound(1) + 1;
Console.WriteLine();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{nums2[i, j]} \t");
    }
    Console.WriteLine();
}

// Зубчатый массив
Console.WriteLine("-----");
int[][] numbers = new int[3][];
numbers[0] = new int[] { 1, 2 };
numbers[1] = new int[] { 1, 2, 3 };
numbers[2] = new int[] { 1, 2, 3, 4, 5 };
// Используя вложенные циклы, можно перебирать зубчатые массивы
foreach (int[] row in numbers)
{
    foreach (int number in row)
    {
        Console.Write($"{number} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("-----");
// перебор с помощью цикла for
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers[i].Length; j++)
    {
        Console.Write($"{numbers[i][j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("-----");

