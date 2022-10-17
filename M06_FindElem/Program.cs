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
int[] array = { 5, 2, 6, 1, 3, 4, 22, 15 };
bool findNumb = FindElem(array, 10);
Console.WriteLine(findNumb);