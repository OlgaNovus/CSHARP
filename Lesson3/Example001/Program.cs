
while (true)
{
    Console.WriteLine("Введите пятизначное число");
    string str1 = Console.ReadLine();

    bool isValidLength = ValidLength(str1);

    if (isValidLength)
    {
        bool isDigit = int.TryParse(str1, out _);

        if (isDigit)
        {
            IsPalindrom(str1);
            break;
        }
        else
        {
            Console.WriteLine("Введенное значение не является числом");
        }
    }
}



static bool ValidLength(string outDigit)
{
    if (outDigit.Length == 5)
    {
        return true;
    }
    Console.WriteLine("Введенное число не пятизначное");
    return false;
}

static void IsPalindrom(string number)
{
    int count = 0;
    int length = number.Length;

    for (int i = 0; i < (length / 2); i++)
    {
        int j = (length - 1) - i;

        if (number[i] == number[j])
        {
            count++;
        }
    }

    if (count == length / 2)
    {
        Console.WriteLine("Число - палиндром");
    }
    else
    {
        Console.WriteLine("Число - не палиндром");
    }
}