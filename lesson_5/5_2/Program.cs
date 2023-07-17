/* Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.
4; [6, 7, 19, 345, 3] -> нет
3: [6, 7, 19, 345, 3] -> да */

string CheckNum(int[] arr, int ch)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == ch) return "Yes";
    }
    return "No";
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число массива: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число массива: ");
int c = int.Parse(Console.ReadLine()!);
Console.Write("Введите проверяемое число: ");
int d = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(a, b, c);
PrintArray(mass);
System.Console.WriteLine(CheckNum(mass, d));