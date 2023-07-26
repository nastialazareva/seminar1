/* Задайте двумерный массив. Напишите программу, которая заменяет
строки на столбцы. В случае, если это невозможно, программа
должна вывести сообщение для пользователя. */

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
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

void ChangeRowsCols(int[,] arr)
{
    if (arr.GetLength(1) != arr.GetLength(0))
        Console.Write("Невозможно перевернуть!");
    else
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] mass = new int[rows, cols];

Console.Write("Введите мин: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите макс: ");
int stop = int.Parse(Console.ReadLine()!);

FillArray(mass, start, stop);
PrintArray(mass);
ChangeRowsCols(mass);
Console.WriteLine();
PrintArray(mass);
