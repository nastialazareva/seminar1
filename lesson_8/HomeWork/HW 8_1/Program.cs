/* Задайте двумерный массив. Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine()!);
int[,] massive = new int[rows, cols];
Console.Write("Введите мин: ");
int start = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите макс: ");
int stop = Convert.ToInt32(Console.ReadLine()!);

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

FillArray(massive, start, stop);

void PrintArray(int[,] arr)
{
    int i, j;
    for (i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}


Console.WriteLine("Исходный массив: ");
PrintArray(massive);
Console.WriteLine();



// Процедура сортировки элементов в строке двумерного массива по убыванию

void PutInOrder(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int sort = 0; sort < arr.GetLength(1) - 1; sort++)
            {
                if (arr[i, sort] < arr[i, sort + 1])
                {
                    int temp = arr[i, sort + 1];
                    arr[i, sort + 1] = arr[i, sort];
                    arr[i, sort] = temp;
                }
            }
        }
    }
}

PutInOrder(massive);
Console.WriteLine("Отсортированный массив: ");
PrintArray(massive);