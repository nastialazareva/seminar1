/* Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X не равно 0 или Y не равно 0 и выдает четверти плоскости,
в которой находится эта точка.*/

void Quaters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0 или y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine(" I четверть");
    else if (x < 0 && y > 0)
        Console.WriteLine("II четверть");
    else if (x < 0 && y < 0)
        Console.WriteLine("III четверть");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV четверть");
}

int numX = int.Parse(Console.ReadLine()!);
int numY = int.Parse(Console.ReadLine()!);
Quaters(numX, numY);