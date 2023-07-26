/* Задайте значения M и N. Напишите программу, которая выведет все
четные натйральные числа в промежутке от M до N с помощью рекурсии. 
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

void PrintNums(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 0)
        Console.Write($"{M} ");
    PrintNums(M + 1, N);

}

PrintNums(M, N);
