// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

Console.WriteLine("Задайте два положительных числа");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
bool isValid = ChekNumber(n);

if (isValid)
{
    Akkerman(m, n);
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

static int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}