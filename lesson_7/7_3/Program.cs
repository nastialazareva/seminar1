/* Задайте двумерный массив. Найдите сумму элементов главной диагонали.
1 4 7
5 9 2
8 4 2
сумма = 1 +9 +2 = 12 */

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
    Console.WriteLine("Массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void SumDiag(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("В массиве нет диагонали!");
        return;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum += array[i, j];
        }
    }
    Console.Write($"Сумма = {sum}");
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] massive = new int[m, n];
Console.Write("Введите мин: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите макс: ");
int stop = int.Parse(Console.ReadLine()!);

FillArray(massive, start, stop);
PrintArray(massive);
SumDiag(massive);