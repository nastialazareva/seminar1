/* Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int TakeNum(int num)
{
    return num / 10 % 10;
}

int newNum = int.Parse(Console.ReadLine()!);
int result = TakeNum(newNum);
Console.WriteLine(result);