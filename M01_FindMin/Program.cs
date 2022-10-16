// Поиск минимума

int FindMin(int[] array)

{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int[] array = { 11, 8, 10, 2, 5, 6, 7, 3, 4, 25 };
int min = FindMin(array);
Console.WriteLine($"Минимальное число равно {min}");