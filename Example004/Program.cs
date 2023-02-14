// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());

int index;
index = 1;

while (index <= N)
{

    index = index + 1;

    if (index % 2 == 0)
    {

        Console.WriteLine(index);
    }
}

Console.WriteLine("END");