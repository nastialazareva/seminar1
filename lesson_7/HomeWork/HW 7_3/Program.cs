/* Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
1 4 7 2
5 9 2 3 
8 4 2 4
Среднее арифметическое = 4,6; 5,6; 3,6; 3. */

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

void FindAvrg(int[,] arr)
{
    double average;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        average = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            average = average + arr[j, i];
        }
        Console.Write($"{Math.Round(average / arr.GetLength(0), 2)}; ");
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
FindAvrg(mass);