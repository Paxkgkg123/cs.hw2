/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int x = InputNumberWithMessage("Input X: ");
int y = InputNumberWithMessage("Input Y: ");

if (x > 0 && y > 0)
    Console.WriteLine("1");
if (x < 0 && y > 0)
    Console.WriteLine("2");
if (x < 0 && y < 0)
    Console.WriteLine("3");
if (x > 0 && y < 0)
    Console.WriteLine("4");