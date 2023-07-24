﻿/*  Задайте значения M и N. Напишите программу, которая 
рекурсивно выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6 , 7, 8" */

void PrintNums(int M, int N)
{
    if (M > N) return;
    PrintNums(M, N - 1);
    Console.Write($"{N} ");
}
PrintNums(1, 5);
