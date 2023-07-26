/* Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.*/

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

int ExpNum(int A, int B)
{
    if (B == 0) return 1;
    return ExpNum(A, B - 1) * A;
}

ExpNum(A, B);
Console.WriteLine($"Число {A} в степени {B} = {ExpNum(A, B)}");