// Функцию, которая вычисляет число a в степени n


int ExpoNumb (int a, int n)
{
    if(n == 1) return a;
    else return a * ExpoNumb(a, n - 1);
}

Console.WriteLine("Введите число: ");
int numA = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите степень числа: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(ExpoNumb(numA, n));
