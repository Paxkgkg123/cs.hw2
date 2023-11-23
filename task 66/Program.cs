/*
Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

int Sum(int m, int n)
{
    if (n < m)
    {
        int t = n;
        n = m;
        m = t;
    }
    
    if (n == m)
        return n;
    
    return m + Sum(m + 1, n);
}

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int m = InputNumberWithMessage("Input m: ");
int n = InputNumberWithMessage("Input n: ");

Console.WriteLine(Sum(m, n));

