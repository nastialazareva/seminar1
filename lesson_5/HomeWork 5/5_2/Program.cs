/* Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечетных позициях.(четный индекс).
*/

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

int SumNum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i += 2)
        count += arr[i];
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
Console.WriteLine("Сумма элементов на нечетных позициях = " + SumNum(mass));