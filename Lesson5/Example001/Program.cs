// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine($"Введено чисел: {numbers.Length}, {EvenNumbers(numbers)} из них чётные");

static int EvenNumbers(int[] numbers)
{
    int count = 0;
    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[j] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

static void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i == numbers.Length - 1)
        {
            Console.Write(numbers[i] + " ");
        }
        else
        {
            Console.Write(numbers[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

