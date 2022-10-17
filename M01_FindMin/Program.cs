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

int size = new Random().Next(5,15);
int[] array = new int[size];

for(int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1,100);

for(int i = 0; i < array.Length; i++)
Console.Write($"{array[i]} ");
Console.WriteLine();

int min = FindMin(array);
Console.WriteLine($"Минимальное число равно {min}");