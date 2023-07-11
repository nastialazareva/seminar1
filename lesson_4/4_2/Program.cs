/* Напишите программу, которая принимает на вход число и выдает количество цифр в числе
456 -> 3
75 -> 2
89126 -> */

int sumNums(int num)
{
    int quantNum = 0;
    for (int i = 1; num > 0; i++)
    {
        num /= 10;
        quantNum = i;
    }
    return quantNum;
}
Console.Write("Введите число: ");
int newNum = int.Parse(Console.ReadLine()!);
int result = sumNums(newNum);
Console.Write("Количество цифр в числе = " + result);