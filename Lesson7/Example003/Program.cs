// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк:");
int arrayLines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов:");
int arrayColumn = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[arrayLines, arrayColumn];
FillArrayRandom(numbers);
PrintArray(numbers);
int[] average = AverageCount(numbers);

static int[] AverageCount(int[,] number)
{
    int dimensionLength = number.GetLength(0);
    int[] result = new int[dimensionLength];

    for (int j = 0; j < dimensionLength; j++)
    {
        int sum = 0;
        for (int i = 0; i < dimensionLength; i++)
        {
            sum = sum + number[i, j];
        }
        result[j] = sum / dimensionLength;
        Console.Write(result[j] + "; ");
    }

    return result;
}

static void FillArrayRandom(int[,] array)
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