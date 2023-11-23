/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    9012 -> 12
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int SumDigit(int number)
{    
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int n = InputNumberWithMessage("Input number: ");

Console.WriteLine(SumDigit(n));
