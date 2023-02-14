// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
int b = int.Parse(Console.ReadLine());

if (a < b)
{
    Console.WriteLine("max = " + b);
}
else

    Console.WriteLine("max = " + a);