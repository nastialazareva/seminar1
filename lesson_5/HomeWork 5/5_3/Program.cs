/* Найдите массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов масива.*/

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}  ");

    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
        arr[i] = Math.Round(n_new.NextDouble() * (to - from) + from, 2);

    return arr;
}

void DiffMaxMin(double[] arr)
{
    double n_max = arr[0];
    double n_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (n_max < arr[i])
            n_max = arr[i];

        else if (n_min > arr[i])
            n_min = arr[i];
    }

    Console.Write($"Максимальное число: {n_max}, Минальное число: {n_min}. ");
    Console.WriteLine($"Разница: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");
}

// 10, 10, 12
Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало массива: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец массива: ");
int c = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(a, b, c);
Print(mass);

DiffMaxMin(mass);
