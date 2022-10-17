// Подсчёт количества положительных элементов в массиве

int CountPos(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

int[] array = { 5, 2, -6, 1, 3, -4, 22, -15, -2, -5, 8, -20 };
int count = CountPos(array);
Console.WriteLine($"Количество положительных элементов в массиве равно: {count}");