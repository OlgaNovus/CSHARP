// Напишите метод, который задаёт массив из N элементов и выводит их на экран.

Console.WriteLine("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int[] filledArray = FillArray(array);
PrintArray(filledArray);

static void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write("{0} ", arrayForPrint[i]);
    }
}

static int[] FillArray(int[] arrayOfNumbers)
{
    int size = arrayOfNumbers.Length;
    Random randomGenerator = new Random();

    for (int i = 0; i < size; i++)
    {
        arrayOfNumbers[i] = randomGenerator.Next(1, 100);
    }

    return arrayOfNumbers;
}
