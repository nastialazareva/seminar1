/* Задайте двумерный массив размером mxn, заполненный случайными
вещественными числами.
m = 3, n = 4
0,5    7     -2    -0,2
1    -3,3    8     -9,9
8     7,8   -7,1     9 */

void PrintArray(double[,] arr)
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

void FillArray(double[,] arr, double min, double max)
{
    Random n_new = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(n_new.NextDouble() * (max - min) + min, 1);
        }
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
double[,] mass = new double[rows, cols];

Console.Write("Введите мин: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите макс: ");
int stop = int.Parse(Console.ReadLine()!);

FillArray(mass, start, stop);
PrintArray(mass);