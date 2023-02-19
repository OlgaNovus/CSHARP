

while (true)
{
    int userNumber;

    bool isDigit = ReadDigit(out userNumber);

    if (isDigit)
    {

        if (numberLess(userNumber))
        {
            Console.WriteLine("Третьей цифры нет.");
        }
        else
        {
            Console.WriteLine("Третья цифра " + userNumber.ToString()[2]);;
            break;
        }
    }
    else
    {
        Console.WriteLine("Введенное вами значение не является числом. Повторите ввод.");
    }
}


bool numberLess(int number)
{
    return (number < 100);
}

static bool ReadDigit(out int outDigit)
{
    Console.WriteLine("Введите трехзначное число.");

    string readStr = Console.ReadLine();

    bool isDigit = int.TryParse(readStr, out outDigit);
    return isDigit;
}
