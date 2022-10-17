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

int size = new Random().Next(5, 15);
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(10, 100);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

int count = CountOddNum(array);
Console.WriteLine($"Количество нечетных элементов в массиве равно: {count}");
