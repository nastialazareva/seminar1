/* Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

void FindLen(int x1, int y1, int z1, int x2, int y2, int z2)
{
    Console.Write("Расстояние между точками = " + Math.Sqrt((Math.Pow((x1 - x2), 2)) + (Math.Pow((y1 - y2), 2)) + (Math.Pow((z1 - z2), 2))));
}

Console.Write("Введите значение x1: ");
int numX1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение y1: ");
int numY1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение z1: ");
int numZ1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение x2: ");
int numX2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение y2: ");
int numY2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение z2: ");
int numZ2 = int.Parse(Console.ReadLine()!);
FindLen(numX1, numY1, numZ1, numX2, numY2, numZ2);