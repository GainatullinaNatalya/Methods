// Поиск максимума

int FindMax(int[] array)

{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int[] array = { 113, 8, 100, 2, 55, 6, 723, 3, 40, 25 };
int max = FindMax(array);
Console.WriteLine($"Максимальное число равно {max}");
