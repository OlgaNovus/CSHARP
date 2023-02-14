// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c");
int c = int.Parse(Console.ReadLine());
int max = a;

if (max < b)
{
    max = b;
}

if (max < c)
{
    max = c;
}
Console.WriteLine("max = " + max);