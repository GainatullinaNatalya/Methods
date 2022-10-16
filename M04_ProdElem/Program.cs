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

int[] array = { 5, 2, 6, 1, 3, 4 };
int prod = ProdElem(array);
Console.WriteLine($"Произведение элементов массива равно {prod}");