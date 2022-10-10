void Compare(int[] numbers1, int[] numbers2)
{
    int numbers1sum = Sum(numbers1);
    int numbers2sum = Sum(numbers2);

    if(numbers1sum > numbers2sum)
    {
        Console.WriteLine("Сумма чисел из массива numbers1 больше чем в массиве numbers2");
    }
    else
    {
        Console.WriteLine("Сумма чисел из массива numbers2 больше чем в массиве numbers1");
    }

    int Sum(int[] numbers)
    {
        int result = 0;
        foreach(int number in numbers)
        {
            result = result + number;
        }
        return result;
    }
}

int[] numbers1 = { 1, 2, 3 };
int[] numbers2 = { 1, 2, 3, 4, 5, 6 };

Compare(numbers1, numbers2);