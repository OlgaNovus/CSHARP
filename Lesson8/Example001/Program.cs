// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.WriteLine("Введите количество строк");
int linesArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsArray = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesArray, columnsArray];

FillArrayRandom(numbers);
PrintArray(numbers);
SortDownArray(numbers);
Console.WriteLine();
PrintArray(numbers);


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

static void SortDownArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int replace = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = replace;
                }
            }
        }
    }
}

void FillArrayRandom(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(0, 100)) / 10;
        }
    }
}