/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
A (3, 6); B (2, 1) -> 5,09
A (7, -5); B (1, -1) -> 7,21*/

void FindLen(int x1, int y1, int x2, int y2)
{
    if (x1 > x2 && y1 > y2)
        Console.Write("Расстояние между точками = " + Math.Sqrt((Math.Pow((x1 - x2), 2)) + (Math.Pow((y1 - y2), 2))));
    else Console.Write("Расстояние между точками = " + Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2))));
}

Console.Write("Введите значение X1: ");
int numX1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение Y1: ");
int numY1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение X2: ");
int numX2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение Y2: ");
int numY2 = int.Parse(Console.ReadLine()!);
FindLen(numX1, numY1, numX2, numY2);