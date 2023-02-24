// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (NaturalNumber(numberB))
{
    int exponentiation = Exponentiation(numberA, numberB);
    Console.WriteLine("Число " + numberA + " в степени " + numberB + " = " + exponentiation);
}

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

static bool NaturalNumber(int numberB)
{
    if (numberB > 0)
    {
        return true;
    }
    Console.WriteLine("Показатель не должен быть меньше 0");
    return false;
}
