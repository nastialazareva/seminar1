/* Задайте массив, заполненный случайными положительными трехзначными числами.
Напишите программу, которая покажет количество четных чисел в массиве.
[345, 897, 568, 134] -> 2 */

void PrintArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < arr.Length; i++)

        Console.Write(arr[i] + " ");
    Console.WriteLine();
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

int EvenOrNotNum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count += 1;
    }
    return count;
}

Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало массива: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец массива: ");
int c = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(a, b, c);
PrintArray(mass);
Console.WriteLine("Количество четных чисел в миссиве: " + EvenOrNotNum(mass));