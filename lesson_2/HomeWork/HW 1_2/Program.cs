/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

void ThirdNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("В этом числе нет третьей цифры");
        return;
    }

    while (num > 999)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}

int newNum = int.Parse(Console.ReadLine()!);
ThirdNum(newNum);
