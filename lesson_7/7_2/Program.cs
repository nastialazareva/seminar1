/* Задайте двумерный массив. Найдите элементы, у которых обе позиции четные,
и замените эти элементы на их квадраты. */

void PrintArray(int[,] arr)
{
    int sizeOfRow = arr.GetLength(0);
    int sizeOfCOl = arr.GetLength(1);

    for (int i = 0; i < sizeOfRow; i++)
    {
        for (int j = 0; j < sizeOfCOl; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            arr[i, j] = new Random().Next(1, 10);
    }
}

void ArrEven(int[,] arr)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);

    for (int i = 1; i < row; i += 2)
    {
        for (int j = 1; j < col; j += 2)
            arr[i, j] *= arr[i, j];
    }
}

Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] mass = new int[m, n];

FillArray(mass);
PrintArray(mass);
Console.WriteLine();
ArrEven(mass);
PrintArray(mass);
