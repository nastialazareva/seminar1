int Max(int num)
{
    if (num / 10 > num % 10)
        return num / 10;

    return num % 10;
}

int RandNum = new Random().Next(10, 100);
Console.WriteLine(RandNum);
int result = Max(RandNum);
Console.WriteLine(result);