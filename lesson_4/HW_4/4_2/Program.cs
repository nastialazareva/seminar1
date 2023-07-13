/* Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int SumNum(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
Console.Write("Введите число: ");
int SumOfNum = int.Parse(Console.ReadLine()!);
Console.Write("Сумма цифр в числе = " + SumNum(SumOfNum));