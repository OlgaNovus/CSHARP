// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента

Console.Write("Введите размер стороны 1: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер стороны 2: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер стороны 3: ");
int side3 = Convert.ToInt32(Console.ReadLine());

bool isSizeOk = checkArraySize(side1, side2, side3);

if (!isSizeOk)
{
    Console.WriteLine("Произведение трех измерений массива не может быть больше 89");
    return;
}

int[,,] array = new int[side1, side2, side3];

FillArray(array);
MixArray(array);
PrintArray(array);

static void MixArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(2) - 1; k++)
            {
                int x = Random.Shared.Next(i + 1, array.GetLength(0) - 1);
                int y = Random.Shared.Next(j + 1, array.GetLength(1) - 1);
                int z = Random.Shared.Next(k + 1, array.GetLength(2) - 1);

                int temp = array[i, j, k];
                array[i, j, k] = array[x, y, z];
                array[x, y, z] = temp;
            }
        }
    }
}

static void FillArray(int[,,] array)
{
    int value = 10;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = value++;
            }
        }
    }
}

static void PrintArray(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("{0}({1},{2},{3}) ", array[i, j, k], i, j, k);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static bool checkArraySize(int side1, int side2, int side3)
{
    int totalNumbers = 89;
    return (side1 * side2 * side3 <= totalNumbers);
}