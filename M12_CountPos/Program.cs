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

int size = new Random().Next(5, 20);
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 10);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

int count = CountPos(array);
Console.WriteLine($"Количество положительных элементов в массиве равно: {count}");