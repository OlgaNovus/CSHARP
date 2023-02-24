// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int number = readNumber();
printPowThreeTable(number);

static void printPowThreeTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine("Куб числа: " + i + " = " + Math.Pow(i, 3));
    }
}

static int readNumber()
{
    int result;
    bool isDigit;

    do
    {
        Console.Write("Введите число: ");
        string userInput = Console.ReadLine();
        isDigit = int.TryParse(userInput, out result);

        if (!isDigit)
        {
            Console.WriteLine("Вы ввели не число. Повторите ввод.");
        }
    } while (!isDigit);

    return result;
}