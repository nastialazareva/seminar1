/* Зайдайте двумерный массив. Напишите программу, которая
поменяет местами первую и последнюю строку массива. */

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

void ChangePlace(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        (arr[0, j], arr[arr.GetLength(0) - 1, j]) = (arr[arr.GetLength(0) - 1, j], arr[0, j]);
    }
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

FillArray(mass, start, stop);
PrintArray(mass);
ChangePlace(mass);
Console.WriteLine();
PrintArray(mass);