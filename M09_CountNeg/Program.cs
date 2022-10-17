// Подсчёт количества отрицательных элементов массива

int CountNeg(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) count++;
    }
    return count;
}

int[] array = { 5, 2, -6, 1, 3, -4, 22, -15, -2, -5, 8, -20 };
int count = CountNeg(array);
Console.WriteLine($"Количество отрицательных элементов в массиве равно: {count}");