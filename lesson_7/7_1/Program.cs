/* Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
A = m+n. Выведите полученный массив на экран.
m = 3, n= 4
0 1 2 3
1 2 3 4 
2 3 4 5 */

void Print(int[,] arr)
{
    int sizeR = arr.GetLength(0);
    int sizeC = arr.GetLength(1);

    for (int i = 0; i < sizeR; i++)
    {
        for (int j = 0; j < sizeC; j++)

            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] MassNums(int rows, int cols)
{
    int[,] arr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            arr[i, j] = i + j;

    return arr;
}

Console.Write("Введите число строк: ");
int NumOfRow = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int NumOfCol = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(NumOfRow, NumOfCol);

Print(mass);