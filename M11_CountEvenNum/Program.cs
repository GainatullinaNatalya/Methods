// Подсчёт количества чётных элементов в массиве

int CountEvenNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count++;
    }
    return count;
}

int[] array = { 5, 2, 6, 1, 3, 4, 22, 5, 2, 5, 8, 20, 8 };
int count = CountEvenNum(array);
Console.WriteLine($"Количество четных элементов в массиве равно: {count}");