/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[,] MatrixCreate(int[,] First_mass, int[,] Second_mass)
{
    int row_size = First_mass.GetLength(0);
    int column_size = First_mass.GetLength(1);
    int[,] massive = new int[row_size, column_size];

    if (row_size != Second_mass.GetLength(0) || column_size != Second_mass.GetLength(1)) return massive;

    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
            massive[i, j] = First_mass[i, j] * Second_mass[i, j];
    return massive;
}


Console.Write("Введите число срок в 1: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов в 1: ");
int column_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число строк в 2: ");
int row_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов в 2: ");
int column_2 = int.Parse(Console.ReadLine()!);

int[,] arr_1 = FillArray(row_1, column_1, 0, 5);
PrintArray(arr_1);
int[,] arr_2 = FillArray(row_2, column_2, 0, 5);
PrintArray(arr_2);

int[,] last_matrix = MatrixCreate(arr_1, arr_2);
PrintArray(last_matrix);