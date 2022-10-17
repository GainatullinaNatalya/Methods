// Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false

bool CheckEvenNumb(int value)
{
    bool numb = false;
    if (value%2 == 0 && value !=0) numb = true;
    return numb;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

bool findNumb = CheckEvenNumb(number);
Console.WriteLine(findNumb);
