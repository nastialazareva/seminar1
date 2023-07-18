/* Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые  два числа Фибаначчи 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

void Fibon(int a)
{
    int temp = 0;
    int temp2 = 1;
    for (int i = 0; i < a; i++)
    {
        Console.Write(temp + " ");
        (temp, temp2) = (temp2, temp + temp2);
    }
}

Fibon(7);