﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

while (true)
{
    Console.WriteLine("Введи трёхзначное число");

    String? readLine = Console.ReadLine();

    if (int.TryParse(readLine, out _))
    {
        Console.WriteLine("Вторая цифра этого числа " + readLine[1]);
        return;
    }
    else
    {
        Console.WriteLine("Буковки не число!");
    }
}