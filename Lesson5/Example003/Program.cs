// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

double max = CalculateMax(numbers);
double min = CalculateMin(numbers);

Console.WriteLine($"Введено чисел: {numbers.Length}. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(max - min, 2)}");

static void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}

static void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
}

static double CalculateMax(double[] numbers)
{
    double max = double.MinValue;
    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[j] > max)
        {
            max = numbers[j];
        }
    }
    return max;
}

static double CalculateMin(double[] numbers)
{
    double min = double.MaxValue;
    for (int k = 0; k < numbers.Length; k++)
    {
        if (numbers[k] < min)
        {
            min = numbers[k];
        }
    }
    return min;
}