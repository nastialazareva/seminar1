//Напишите программу, которая принимает на вход число и проверяет, кратно оно одновременно 7 или 23.

void Crat(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        Console.WriteLine("Да");
    else
    {
        Console.WriteLine("Неть");
    }
}

int newNum = int.Parse(Console.ReadLine()!);
Crat(newNum);