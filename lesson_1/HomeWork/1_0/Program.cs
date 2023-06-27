int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.Write("Максимум= " + a);
}
else if (b > a)
{
    Console.Write("Максимум= " + b);
}
else
    Console.Write("Числа равны между собой");