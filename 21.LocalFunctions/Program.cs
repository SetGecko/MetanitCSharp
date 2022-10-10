void Compare(int[] numbers1, int[] numbers2)
{
    int numbers1sum = 0;
    int numbers2sum = 0;

    foreach(int number in numbers1)
    {
        numbers1sum = numbers1sum + number;
    }

    foreach (int number in numbers2)
    {
        numbers2sum = numbers2sum + number;
    }

    if(numbers1sum > numbers2sum)
    {
        Console.WriteLine("Сумма чисел из массива numbers1 больше чем в массиве numbers2");
    }
    else
    {
        Console.WriteLine("Сумма чисел из массива numbers2 больше чем в массиве numbers1");
    }
}

int[] numbers1 = { 1, 2, 3 };
int[] numbers2 = { 1, 2, 3, 4, 5, 6 };

Compare(numbers1, numbers2);


