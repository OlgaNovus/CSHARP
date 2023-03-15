// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

Console.WriteLine("Введите неотрицательное целое число");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
bool isValid = ChekNumber(n);

if (isValid)
{
    NaturalNumbers(n, m);
}

static bool ChekNumber(int n)
{
    if (n < 1)
    {
        Console.WriteLine("Введенное число не может быть меньше 1");
        return false;
    }

    return true;
}

static int NaturalNumbers(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    else
    {
        int result = NaturalNumbers(n, m + 1);

        Console.Write("{0}", result);

        if (m >= 1)
        {
            Console.Write(", ");
        }

        return m;
    }
}