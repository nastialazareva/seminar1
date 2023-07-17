// Напишите программу, которая будет создавать копию заданного двумерного массива
// с помощью поэлементного копирования.

void Print(int[,] arr)
{
    int sizeOfRow = arr.GetLength(0);
    int sizeOfCOl = arr.GetLength(1);

    for (int i = 0; i < sizeOfRow; i++)
    {
        for (int j = 0; j < sizeOfCOl; j++)

            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int col, int a, int b)
{
    int[,] arr = new int[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            arr[i, j] = new Random().Next(a, b + 1);

    return arr;
}

int[,] ArrCopy(int[,] arr)
{
    int sizeOfRow = arr.GetLength(0);
    int sizeOfCOl = arr.GetLength(1);
    int[,] newArr = new int[sizeOfRow, sizeOfCOl];

    for (int i = 0; i < sizeOfRow; i++)
        for (int j = 0; j < sizeOfCOl; j++)
            newArr[i, j] = arr[i, j];

    return newArr;
}

Console.Write("Введите число строк: ");
int NumOfRow = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int NumOfCol = int.Parse(Console.ReadLine()!);

Console.Write("Введите мин: ");
int newA = int.Parse(Console.ReadLine()!);
Console.Write("Введите макс: ");
int newB = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(NumOfRow, NumOfCol, newA, newB);

Print(mass);
int[,] newArr = ArrCopy(mass);
Print(newArr);