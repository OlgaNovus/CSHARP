// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

Console.WriteLine("Введите количество строк");
int linesArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsArray = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesArray, columnsArray];
FillArrayRandom(numbers);
PrintArray(numbers);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {RowNumMinSum(numbers)}");

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

static int RowNumMinSum(int[,] numbers)
{
    int dimensionLength = numbers.GetLength(0);
    int[] result = new int[dimensionLength];

    int leastSum = int.MaxValue;
    int rowLeastSum = 0;

    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        int sum = 0;

        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            sum = sum + numbers[j, i];
        }

        if (sum < leastSum)
        {
            leastSum = sum;
            rowLeastSum = j;
        }
    }

    return rowLeastSum;
}