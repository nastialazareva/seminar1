/* Напишите программу, которая найдет точку пересечения двух прямых,
заданных уравнениями y=k1*x+b1, y=k2*x+b2; значения b1, k1, b2 и k2
задаются пользователем. */

void Peresec(double k1, double b1, double k2, double b2)
{
    double znam = k1 - k2;

    if (znam != 0)
    {
        double x = (b2 - b2) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine("Точка пересечения: " + x, y);
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Тут выходит бесконечная точка пересечений");
    else
        Console.WriteLine("Точки пересечения вообще нет!");
}

Console.Write("Введитие число k1: ");
int newK1 = int.Parse(Console.ReadLine()!);
Console.Write("Введитие число b1: ");
int newB1 = int.Parse(Console.ReadLine()!);
Console.Write("Введитие число k2: ");
int newK2 = int.Parse(Console.ReadLine()!);
Console.Write("Введитие число b2: ");
int newB2 = int.Parse(Console.ReadLine()!);

Peresec(newK1, newB1, newK2, newB2);