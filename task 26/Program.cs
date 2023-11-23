/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    456 -> 3
    89126 -> 5
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int CountDigit(int number)
{    
    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

int n = InputNumberWithMessage("Input number: ");

Console.WriteLine(CountDigit(n));
