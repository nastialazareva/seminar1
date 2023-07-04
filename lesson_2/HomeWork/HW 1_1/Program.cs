/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98*/

string SecNum(int num)
{
    if (num < 1000 && num > 99)
        return $"{num} = {num / 100 * 10 + num % 10}";

    return "Это не трехзначное число";
}

int newNum = int.Parse(Console.ReadLine()!);
string result = SecNum(newNum);
Console.WriteLine(result);
