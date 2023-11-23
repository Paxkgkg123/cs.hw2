/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int OutputNumbers(int n)
{
    Console.Write($"{n} ");
    
    if (n == 1)
        return 0;
    
    return OutputNumbers(n - 1);
}

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}


int n = InputNumberWithMessage("Input n: ");

if (n >= 1)
    OutputNumbers(n);
    
if (n < 1)
    Console.Write("n < 0");

