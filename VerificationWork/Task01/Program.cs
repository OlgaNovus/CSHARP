// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которы меньше либо равна 3 символа.

Console.Write("Задайте значения внутри массива через запятую: ");
string[] inputArray = Console.ReadLine().Split(",");
string[] secondArray = new string[] { };

PrintArray(inputArray);
FindShortWords(inputArray, ref secondArray);
Console.WriteLine("\n");
PrintArray(secondArray);

static void FindShortWords(string[] inputArray, ref string[] outputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            Array.Resize(ref outputArray, outputArray.Length + 1);
            int lastIndex = outputArray.Length - 1;
            outputArray[lastIndex] = inputArray[i];
        }
    }
}

static void PrintArray(string[] inputArray)
{
    Console.Write("[ ");
    for (int i = 0; i < inputArray.Length; i++)
    {

        Console.Write($"{inputArray[i]}");
        if (i != inputArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write(" ]");
}