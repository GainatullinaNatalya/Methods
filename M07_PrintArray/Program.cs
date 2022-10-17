// Печать массива на экран

void PrintArray(int[] array)
{
    for (int i= 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int size = 10;
int[]array = new int[size];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 10);

PrintArray(array);