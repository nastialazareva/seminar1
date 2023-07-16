// Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

void ConvBin(int num)
{
    string result = "";

    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    Console.Write("Это число в двоичном виде = " + result);
}

Console.Write("Введите десятичное число: ");
int newNum = int.Parse(Console.ReadLine()!);
ConvBin(newNum);