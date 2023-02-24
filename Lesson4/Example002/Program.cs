// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе

int usrInpt = readNumber();
Console.WriteLine("Сумма всех чисел в числе " + usrInpt + " = " + SumNumber(usrInpt));

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
            Console.WriteLine("Введенное значение - не число. Повторите ввод.");
        }
    } while (!isDigit);

    return result;
}

static int SumNumber(int number)
{
    int result = 0;

    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
