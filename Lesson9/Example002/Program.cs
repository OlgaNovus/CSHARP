// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
bool isValid = ChekNumber(m, n);

if (isValid)
{
    Console.WriteLine("Сумма элементов = {0}", SumNaturalNumbers(m, n, 0));
}

static bool ChekNumber(int m, int n)
{
    if (m < 1 || n < 1)
    {
        Console.WriteLine("Введенное число не может быть меньше 1");
        return false;
    }
    return true;
}

static int SumNaturalNumbers(int m, int n, int numberIteration)
{
    if (m == n)
    {
        return n;
    }
    if (m > n)
    {
        return n + SumNaturalNumbers(n + 1, m, numberIteration + 1);
    }
    else
    {
        Console.WriteLine("m = {0}, n = {1}, iteration: {2}", m, n, numberIteration);
        return m + SumNaturalNumbers(m + 1, n, numberIteration + 1);
    }
}

