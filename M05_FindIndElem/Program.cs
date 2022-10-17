// Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1

int FindIndElem(int[] array, int value)
{
    int findElem = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value) 
        {
            findElem = i;
            break;
        }
    }
    return findElem;
}

int size = new Random().Next(5,15);
int[] array = new int[size];

for(int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1,100);

for(int i = 0; i < array.Length; i++)
Console.Write($"{array[i]} ");
Console.WriteLine();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int index = FindIndElem(array, n);
Console.WriteLine(index);



