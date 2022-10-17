// Среднее арифметическое элеметов массива

double ArithMean(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    double S = sum / array.Length;
    return S;
}

int size = new Random().Next(5, 10);
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

double medium = ArithMean(array);
Console.WriteLine($"Среднее арифметическое элеметов массива: {medium}");
