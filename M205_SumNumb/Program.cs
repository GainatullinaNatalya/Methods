// Функцию, складывающую два целых числа

int SumNumb(int a, int b)
{
    int sum = a + b;
    return sum;
}

Console.WriteLine("Введите целое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите целое число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

int sum = SumNumb(a, b);

Console.WriteLine($"Сумма целых чисел равна {sum}");
