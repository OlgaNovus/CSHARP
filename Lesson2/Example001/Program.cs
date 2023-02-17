// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

while (true)
{
    string outStr;
    bool chekResult = ReadAndCheck(out outStr);

    if (chekResult)
    {
        if (outStr.Length == 3)
        {
            Console.WriteLine(outStr[1]);
            break;
        }

        Console.WriteLine("Введеное вами число не трехзначное. Повторите ввод.");
    }
    else
    {
        Console.WriteLine("Введенное вами значение \"{0}\" не является числом. Повторите ввод.", outStr);
    }
}

static bool ReadAndCheck(out string str)
{
    Console.WriteLine("Введите трехзначное число.");  
    
    string readStr = Console.ReadLine();                    
    str = readStr;                                          
    
    bool isDigit = int.TryParse(readStr, out _);            
    return isDigit;                                         
}