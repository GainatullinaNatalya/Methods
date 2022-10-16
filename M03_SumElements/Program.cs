// Поиск суммы элементов массива

int SumElements(int[] array)

{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = { 1, 8, 2, 5, 6, 7, 3, 4 };
int sum = SumElements(array);
Console.WriteLine($"Сумма элементов массива равна {sum}");
