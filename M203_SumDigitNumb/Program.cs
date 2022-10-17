// Функцию, которая вычисляет сумму цифр произвольного целого числа n

int SumDigitNumb(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int digit = n % 10;
        sum += digit;
        n = n / 10; ;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int sum = SumDigitNumb(n);

Console.WriteLine($"Сумма цифр = {sum}");