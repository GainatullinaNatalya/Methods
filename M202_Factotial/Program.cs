// Функцию, которая вычисляет факториал числа n

double Factorial (double n)
{
    if(n == 1) return 1;
    else return n * Factorial(n -1);
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(Factorial(number));