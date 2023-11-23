/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

int IntToBinar(int n)
{
    int result = 0;
    for (double i = 0; n >= 1; i++)
    {
        result += (n % 2) * (int)Math.Pow(10, i);
        n /= 2;
    }
    return result;
}

Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());
Console.Write(IntToBinar(n));