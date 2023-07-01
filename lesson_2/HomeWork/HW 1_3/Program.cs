/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

void DayNum(int num)
{
    if (num >= 1 && num <= 5)
    {
        Console.WriteLine(num + " - Да, это будний день");
    }
    else if (num >= 6 && num <= 7)
    {
        Console.WriteLine(num + " - Нет, это выходной день");
    }
    else
        Console.WriteLine(num + " - это вообще не день недели!!");
}

int newDay = int.Parse(Console.ReadLine()!);
DayNum(newDay);