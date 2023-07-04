void rem(int a, int b)
{
    if (a % b == 0)
        Console.WriteLine("Числа кратны");
    else
    {
        Console.WriteLine("Числа не кратны " + a % b);
    }
}

int numA = int.Parse(Console.ReadLine()!);
int numB = int.Parse(Console.ReadLine()!);
rem(numA, numB);