/* Напишите программу, которая перевернёт одномерный массив
  (последний элемент будет на первом месте, а первый - на последнем и т.д.) */

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)

        Console.Write(arr[i] + " ");
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

void ChangeNum(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        (arr[i], arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1], arr[i]);
    }

}

Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало массива: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец массива: ");
int c = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(a, b, c);
PrintArray(mass);
Console.WriteLine();
ChangeNum(mass);
PrintArray(mass);