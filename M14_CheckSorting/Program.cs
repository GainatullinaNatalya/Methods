// Проверка является ли массив отсортированным по возрастанию. 
//Если массив отсортирован, то возвращать true, иначе - false

bool CheckSorting(int[] array)
{
    bool checkArray = true;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1]) 
        {
            checkArray = false;
        }
    }
    return checkArray;
}

int[] array = { 1, 2, 3, 4, 3, 10, 22, 25 };
bool sort = CheckSorting(array);
Console.WriteLine(sort);
