/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон
    возможных координат точек в этой четверти (x и y).
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int n = InputNumberWithMessage("Input number: ");

if (n == 1)
    Console.WriteLine("x > 0 and y > 0");
if (n == 2)
    Console.WriteLine("x < 0 and y > 0");
if (n == 3)
    Console.WriteLine("x < 0 and y < 0");
if (n == 4)
    Console.WriteLine("x > 0 and y < 0");
if (n < 1 || n > 4)
    Console.WriteLine("That quarter does not exist");