


void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; size; i++)
        Console.Write($"{array[i]}");
    Console.WriteLine();
}

int[] EightArr(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to + 1);
    return array;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightArr(num, start, stop);
Print(mass);