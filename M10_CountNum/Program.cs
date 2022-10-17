// Подсчёт количества вхождений элемента в массив

int CountNum(int[] array, int value)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == value) count++;
    return count;
}

int[] array = { 5, 2, 6, 1, 3, 4, 22, 2, 8, 20, 2, 4, 5 };
int count = CountNum(array, 2);
Console.WriteLine($"Количество вхождений элемента в массив равно: {count}");