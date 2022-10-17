// Подсчёт количества вхождений элемента в массив

int CountNum(int[] array, int value)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == value) count++;
    return count;
}

int size = new Random().Next(5, 20);
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int count = CountNum(array, n);
Console.WriteLine($"Количество вхождений элемента в массив равно: {count}");