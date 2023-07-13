/* Напишите программу замена элементов массива: положительные - на соответствующие отрицательные,
а отрицательные - на положительные.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

void ChangeNums(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
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

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);


int[] mass = MassNums(a, b, c);
PrintArray(mass);
ChangeNums(mass);
PrintArray(mass);