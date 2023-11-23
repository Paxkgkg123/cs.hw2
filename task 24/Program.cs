/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
    7 -> 28
    4 -> 10
    8 -> 36
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int Sum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
        sum += i;
    return sum;
}

int a = InputNumberWithMessage("Input a: ");
Console.WriteLine(Sum(a));