// Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

void CheckSide(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + c > b)
        Console.Write("Такой треугольник существует!");
    else
        Console.Write("Такой треугольник не существует!");
}

Console.Write("Введите длину a: ");
int newNum1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину b: ");
int newNum2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину c: ");
int newNum3 = int.Parse(Console.ReadLine()!);

CheckSide(newNum1, newNum2, newNum3);