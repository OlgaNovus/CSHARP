// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.WriteLine("введите количество строк:");
int arrayLines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов:");
int arrayColumn = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[arrayLines, arrayColumn];
FillArrayRandom(numbers);
PrintArray(numbers);

static void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

static void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(String.Format("{0,3}", array[i, j]));

                if (j != array.GetLength(1) - 1) {
                     Console.Write("\t");
                }
            }
        Console.WriteLine("]");
    }
}
