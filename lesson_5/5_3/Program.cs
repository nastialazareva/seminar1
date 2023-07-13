
/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
Пример: массив из 5 элементов
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] ->5 */

int CheckAndCountNum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) count++;
    }
    return count;
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
Console.Write("Введите начало массива: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец массива: ");
int c = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(a, b, c);
PrintArray(mass);
System.Console.WriteLine("Количество чисел = " + CheckAndCountNum(mass));