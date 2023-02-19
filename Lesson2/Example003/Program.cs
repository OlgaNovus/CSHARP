// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

while (true)
{
    string inputStr = RequestInput();

    int digit;
    if (IsAndToDigit(inputStr, out digit))
    {
        if (IsDayOfWeek(digit))
        {
            if (IsWeekend(digit))
            {
                Console.WriteLine("Поздравляем! Это выходной :)");
                break;
            }
            else
            {
                Console.WriteLine("Это не выходной!");
            }
        }
        else
        {
            Console.WriteLine("Это не день недели!");
        }
    }
    else
    {
        Console.WriteLine("Это не число!");
    }
}

//===================================================
string RequestInput()
{
    Console.WriteLine("Введите число, которое день недели");
    return Console.ReadLine();
}

bool IsAndToDigit(string str, out int digit)
{
    return int.TryParse(str, out digit);
}

bool IsDayOfWeek(int day)
{
    return (day > 0 && day <= 7);
}

bool IsWeekend(int day)
{
    return (day == 6 || day == 7);
}