/* Напишите программу, которая принимает на вход пятизначное число и
проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

void FindSame(int num)
{
    int num12 = num / 1000;
    int num4 = num / 10 % 10;
    int num5 = num % 10;

    if (num12 == num4 + num5 * 10)
        Console.Write(num + " - это палиндром");
    else
        Console.Write(num + " - это не палиндром");
}
Console.Write("Введите число из 5 цифр: ");
int bigNum = int.Parse(Console.ReadLine()!);
FindSame(bigNum);