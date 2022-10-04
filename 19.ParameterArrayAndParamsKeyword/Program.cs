void Addition (params int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result = result + numbers[i];
    }
    Console.WriteLine (result);
}
Addition(new int[] { 1, 2, 3, 4 });
Addition(1, 1, 1, 2);
Addition();

void Sum(int initialValue, params int[] numbers)
{
    int result = initialValue;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}

int[] nums = { 1, 2, 3, 4, 5 };
Sum(10, nums);  // число 10 - передается параметру initialValue
Sum(1, 2, 3, 4);
Sum(1, 2, 3);
Sum(20);

