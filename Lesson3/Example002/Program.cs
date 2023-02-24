// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = RequestCoords("x", "A");
int y1 = RequestCoords("y", "A");
int z1 = RequestCoords("z", "A");
int x2 = RequestCoords("x", "B");
int y2 = RequestCoords("y", "B");
int z2 = RequestCoords("z", "B");

double lineSegment = CalculateLength(x1, x2, y1, y2, z1, z2);
Console.WriteLine("Расстояние между точками: " + lineSegment);


int RequestCoords(string coordinates, string point)
{
    bool isDigit;
    int result;

    do 
    {
        Console.Write("Введите координату " + coordinates + " точки " + point + ": ");
        string userInput = Console.ReadLine();

        isDigit = int.TryParse(userInput, out result);

        if (!isDigit)
        {
            Console.WriteLine("Вы ввели не число. Повторите ввод.");
        }
    } while (!isDigit);
    return result;
}

static double CalculateLength(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return length;
}

