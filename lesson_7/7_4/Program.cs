/* Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
выведите позиции по горизонтали и вертикали, или напишите, то такого элемента нет.
1 4 7 2
5 9 2 3
8 4 2 4
Введенный элемент = 2, результат [1, 4]
Введенный элемент = 6, результат: такого элемента нет. */

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

string FindNum(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num) return $"[{i + 1},{j + 1}]";
        }
    }
    return "Не найдено";
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
Console.Write("Введите число: ");
int newNum = int.Parse(Console.ReadLine()!);

FillArray(mass, start, stop);
PrintArray(mass);
Console.WriteLine("Число на позиции: " + FindNum(mass, newNum));