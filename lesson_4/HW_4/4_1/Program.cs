/* Напиши цикл, который принимает на вход два числа (A и B) и возводит A
в натуральную степень B.
3,5 -> 243
2,4 -> 16 */

double NumsMult(int num_1, int num_2)
{
    double result = 1;
    int num_2_pos = Math.Abs(num_2);
    for (int i = 1; i <= num_2_pos; i++)
    {
        if (num_2 > 0)
            result = result * num_1;
        else
            result = result / num_1;
    }
    return result;
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Число равно = " + NumsMult(A, B));
