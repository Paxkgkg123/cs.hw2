/*
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int n = InputNumberWithMessage("input number: ");

int result = n / 10 % 10;

Console.Write(result);