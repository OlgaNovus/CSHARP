// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

Console.WriteLine($"Введено чисел: {numbers.Length}. Сумма всех нечетных чисел = {SumOddNumbers(numbers)}");

static int SumOddNumbers(int[] numbers)
{
    int sum = 0;
    for (int j = 0; j < numbers.Length; j += 2)
    {
        sum = sum + numbers[j];
    }
    return sum;
}

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
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