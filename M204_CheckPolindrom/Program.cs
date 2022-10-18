// Функцию, которая проверяет является ли заданное число n полиндромом

int ReverseNum (int number)
    {
    int two = 0;
    while (number > 0)
    {
        int dig = number % 10;
        two = two * 10 + dig;
        number = number / 10;
    }
    return two;
    }

bool CheckPolindrom(int num)
{
    int rev = ReverseNum(num);

    bool answ = false;
    if (rev == num) answ = true;
    return answ;
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

bool result = CheckPolindrom(n);
Console.WriteLine(result);