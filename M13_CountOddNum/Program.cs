// Подсчёт количества нечётных элементов в массиве

int CountOddNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 1) count++;
    }
    return count;
}

int[] array = { 5, 2, 6, 1, 3, 4, 22, 5, 2, 5, 8, 20, 8 };
int count = CountOddNum(array);
Console.WriteLine($"Количество нечетных элементов в массиве равно: {count}");
