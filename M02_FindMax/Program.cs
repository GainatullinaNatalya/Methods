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

int size = new Random().Next(5,15);
int[] array = new int[size];

for(int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1,100);

for(int i = 0; i < array.Length; i++)
Console.Write($"{array[i]} ");
Console.WriteLine();

int max = FindMax(array);
Console.WriteLine($"Максимальное число равно {max}");
