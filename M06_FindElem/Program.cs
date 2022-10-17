// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет

bool FindElem(int[] array, int value)
{
    bool findElem = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value) findElem = true;
    }
    return findElem;
}
int size = new Random().Next(5, 10);
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

bool findNumb = FindElem(array, n);
Console.WriteLine(findNumb);