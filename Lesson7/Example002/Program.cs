// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
//или же указание, что такого элемента нет

Console.WriteLine("Введите номер строки:");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int column = Convert.ToInt32(Console.ReadLine());

int[,] myArray = new int[10, 10];
FillArrayRandom(myArray);
PrintArray(myArray);
DesiredValue(myArray, line, column);

static void DesiredValue(int[,] numbers, int line, int column)
{
    if (line > numbers.GetLength(0) || column > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {line} строки и {column} столбца равно {numbers[line - 1, column - 1]}");
    }
}

static void FillArrayRandom(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
}

static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3}", array[i, j]));

            if (j != array.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine("]");
    }
}