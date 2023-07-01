int a = int.Parse(Console.ReadLine()!);
int count = -a;
Console.WriteLine(count);
while (count != a)
{
    if (a > 0)
        count++;
    else
        count--;
    Console.WriteLine(count);
}


// условия проверяет полож или отриц значение мы вводим в a
//если вводим а полож, то count идет отриц и наоброт