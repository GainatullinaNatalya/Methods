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

int size = new Random().Next(5, 15);
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

int count = CountEvenNum(array);
Console.WriteLine($"Количество четных элементов в массиве равно: {count}");