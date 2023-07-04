﻿/* Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (X и Y).*/

void Coord(int num)
{
    if (num <= 0 || num > 4)
        Console.WriteLine("Данное число не является номером четверти!");
    else if (num == 1)
        Console.WriteLine("Координаты в данной четверти: X от 1 до + бесконечности, Y от 1 до + бесконечности");
    else if (num == 2)
        Console.WriteLine("Координаты в днной четверти: X то -1 до -бесконечности, Y от 1 до +бесконечости");
    else if (num == 3)
        Console.WriteLine("Координаты в днной четверти: X то -1 до -бесконечности, Y от -1 до -бесконечости");
    else if (num == 4)
        Console.WriteLine("Координаты в днной четверти: X то 1 до +бесконечности, Y от -1 до -бесконечости");
}

Console.WriteLine("Ведите номер четверти: ");
int numCoord = int.Parse(Console.ReadLine()!);
Coord(numCoord);