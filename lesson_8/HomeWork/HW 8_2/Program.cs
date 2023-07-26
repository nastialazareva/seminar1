/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов.
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

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


int[,] FillArray(int row, int col, int min, int max)
{
    int[,] arr = new int[row, col];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

int[] FindSum(int[,] arr)
{
    int[] nums = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            nums[i] += arr[i, j];
        }
    }
    return nums;
}

void FindMin(int[] arr)
{
    int min_index = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[min_index]) min_index = i;
    }
    Console.WriteLine($"Сумма элементов = {arr[min_index]}, Строка: {min_index + 1}");
}

Console.Write("Впишите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Впишите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
;

Console.Write("Впишите мин: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Впишите макс: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = FillArray(rows, cols, start, stop);
PrintArray(mass);

int[] summOfArray = FindSum(mass);
FindMin(summOfArray);
