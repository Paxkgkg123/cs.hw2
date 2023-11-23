/*
Задача 40: Напишите программу, которая принимает на вход 
три числа и проверяет, может ли существовать треугольник 
с сторонами такой длины.
*/

int[] InputArray()
{
    string s = Console.ReadLine();
    string[] split = s.Split(" ");
    int[] arr = new int[split.Length];
    
    for (int i = 0; i < split.Length; i++)
    {
        arr[i] = int.Parse(split[i]);
    }
    
    return arr;
}

void Check(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("may");
        return;
    }
    Console.WriteLine("don`t may");
}

Console.Write("Input a, b, c: ");
int[] arr = InputArray();
Check(arr[0], arr[1], arr[2]);