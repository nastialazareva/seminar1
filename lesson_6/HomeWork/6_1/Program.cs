// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 он ввел.

int CheckNum(int num)
{
    int count = 0;

    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int b = int.Parse(Console.ReadLine()!);
        if (b > 0)
            count++;
    }
    return count;
}

Console.Write("Введите количество цифр: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество чисел больше 0: " + CheckNum(a));