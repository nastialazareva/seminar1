/* Задайте значения M и N. Напишите программу, которая найдет сумму
натуральных элементов в промежутке от M до N с помощью рекурсии. */

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

if (M < 1) M = 1;
if (N < 1) Console.Write("Нет заданных чисел!");
{
    SumNum(M, N);
    void SumNum(int M, int N)
    {
        Console.Write("Сумма чисел = " + SumNew(M - 1, N));
    }

    int SumNew(int M, int N)
    {
        int result = M;
        if (M == N) return 0;
        M++;
        result = M + SumNew(M, N);
        return result;
    }
}