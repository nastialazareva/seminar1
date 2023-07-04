/* Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

string TakeNum(int num)
{
    if (num > 100 && num < 1000)
        return $"{num / 10 % 10}";
    return "Это число не является трехзначным";
}

int newNum = int.Parse(Console.ReadLine()!);
string result = TakeNum(newNum);
Console.WriteLine(result);