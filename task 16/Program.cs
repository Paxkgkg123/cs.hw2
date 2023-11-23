/*
Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
    5, 25 -> да
    -4, 16 -> да
    25, 5 -> да
    8,9 -> нет
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int a = InputNumberWithMessage("Input first number: ");
int b = InputNumberWithMessage("Input second number: ");

if (a == Math.Pow(b, 2) || b == Math.Pow(a, 2))
    Console.WriteLine("yes");
else
    Console.WriteLine("no");