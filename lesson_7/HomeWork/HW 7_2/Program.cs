/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента нет. */

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void NumZnach(int[,] arr, int num1, int num2)
{
    if (num1 > arr.GetLength(0) || num2 > arr.GetLength(1))
        Console.Write("Такого элемента не чущестувет");
    else
        Console.Write("Значение = " + arr[num1, num2]);
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] mass = new int[rows, cols];

Console.Write("Введите мин: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите макс: ");
int stop = int.Parse(Console.ReadLine()!);

Console.Write("Введите первое значение: ");
int newNum1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе значение: ");
int newNum2 = int.Parse(Console.ReadLine()!);

FillArray(mass, start, stop);
PrintArray(mass);
NumZnach(mass, newNum1, newNum2);