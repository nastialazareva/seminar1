/* Задайе массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Пример: массив [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел = 29,
а сумма отрицательных чисел = -20. */

void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]}");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to + 1);
    return array;
}

void SumPosNeg(int[] array)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
            pos += array[i];
        else neg += array[i];
    }
    Console.WriteLine($"Положительные: {pos}, Отрицательные: {neg}");
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass);