/* Напишите программу, которая будет принимать на вход число
и возвращать сумму его цифр. Использовать рекурсию.
453 -> 12
45 -> 9*/

Console.Write("Введите число N: ");
int num = int.Parse(Console.ReadLine()!);

int SumNum(int num)
{
    if (num / 10 == 0) return num;
    return SumNum(num / 10) + num % 10;
}

SumNum(num);
Console.WriteLine($"Сумма = {SumNum(num)}");