/* Напишите программу, которая принимает на вход число (N) и 
выдает таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25
2 -> 1, 4*/

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 1;
if (a == 0)
    Console.WriteLine("1");
else
{
    while (count <= Math.Abs(a))
    {
        Console.WriteLine(Math.Pow(count, 2));
        count++;
    }
}