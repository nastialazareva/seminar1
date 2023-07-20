/* Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается
элемент входных данных. */

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


Console.Write("Введите мин: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите макс: ");
int max = int.Parse(Console.ReadLine()!);

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

int[] FriqDic(int[,] arr)
{
    int[] friq = new int[max + 1];

    foreach (int i in arr)
    {
        friq[i] += 1;
    }
    return friq;
}

void PrintMass(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) Console.WriteLine($"{i} - {arr[i]} ");
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] mass = new int[rows, cols];

FillArray(mass);
PrintArray(mass);
Console.WriteLine();
int[] FriqArray = FriqDic(mass);
PrintMass(FriqArray);