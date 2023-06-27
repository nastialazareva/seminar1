int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max = 0;

if (a < b)
{
    a = b;
}
if (a < c)
{
    a = c;
}

Console.WriteLine("Максимум = " + a);