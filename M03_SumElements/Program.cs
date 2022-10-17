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

int size = new Random().Next(5, 15);
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

int sum = SumElements(array);
Console.WriteLine($"Сумма элементов массива равна {sum}");
