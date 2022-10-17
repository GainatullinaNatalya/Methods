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

int[] array = { 2, 5, 6, 3, 8, 10};
double medium = ArithMean(array);
Console.WriteLine($"Среднее арифметическое элеметов массива: {medium}");
