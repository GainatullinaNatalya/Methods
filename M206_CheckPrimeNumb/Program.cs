// Функцию, определяющую является ли число простым, 
//то есть возвращающую true, если число простое, иначе - false

bool CheckPrimeNumb(int number)
{
    bool find = true;
    int count = 0;
    for(int i = 2; i < number / 2; i++)
    {
        if(number%i == 0) count ++;
    }
    if(count > 0 || number == 1 || number < 0) find = false;
    return find;
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

bool number = CheckPrimeNumb(n);
Console.WriteLine(number);
