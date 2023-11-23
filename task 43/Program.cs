/*
Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


double Input(string massage)
{
    Console.Write(massage);
    double k = double.Parse(Console.ReadLine());
    return k;
}


double b1 = Input("b1 = ");
double k1 = Input("k1 = ");
double b2 = Input("b2 = ");
double k2 = Input("k2 = ");

if (k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые одинаковы");
if (k1 == k2 && b1 != b2)
    Console.WriteLine("Прямые параллельны");
if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"({x};{y})");
}
