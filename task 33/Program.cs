/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
    4; массив [6, 7, 19, 345, 3] -> нет
    3; массив [6, 7, 19, 345, 3] -> да
*/

int[] CreateArray(int size, int min, int max) 
{
    var random = new Random();
    
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) 
    {
        arr[i] = random.Next(min, max + 1);
    }
    return arr;
}

void Output(int[] arr) 
{
    
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

bool IsBelong(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        return true;
    }
    return false;
}

int[] arr = CreateArray(4, -21, 10);
Output(arr);

Console.Write(" Введите n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(IsBelong(arr, n));