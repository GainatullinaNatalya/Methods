// Поиск произведения элементов массива

int ProdElem(int[] array)
{
    int prod = 1;
    for (int i = 0; i < array.Length; i++)
    {
        prod = prod * array[i];
    }
    return prod;
}

int size = new Random().Next(5, 10);
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

int prod = ProdElem(array);
Console.WriteLine($"Произведение элементов массива равно {prod}");