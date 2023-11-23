/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
    A (3,6); B (2,1) -> 5,09
    A (7,-5); B (1,-1) -> 7,21
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int ax = InputNumberWithMessage("Input ax: ");
int ay = InputNumberWithMessage("Input ay: ");
int bx = InputNumberWithMessage("Input bx: ");
int by = InputNumberWithMessage("Input by: ");

double dxPow = Math.Pow(ax - bx, 2);
double dyPow = Math.Pow(ay - by, 2);

double distance = Math.Sqrt(dxPow + dyPow);
Console.WriteLine(distance);