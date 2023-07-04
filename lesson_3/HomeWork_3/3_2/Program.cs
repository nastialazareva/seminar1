/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 1;
if (a == 0)
    Console.WriteLine("1");
else
{
    while (count <= Math.Abs(a))
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}