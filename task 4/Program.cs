/*
Найти максимальное из трёх чисел.   
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int Max(int a, int b, int c)
{
    if (a >= b && a >= c)
        return a;
    if (b >= c)
        return b;
    return c;
}

int a = InputNumberWithMessage("Input first number: ");
int b = InputNumberWithMessage("Input second number: ");
int c = InputNumberWithMessage("Input third number: ");

Console.WriteLine(Max(a, b, c));