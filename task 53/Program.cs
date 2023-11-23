/*
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

int[,] CreateTwoDimentionalArray(int m, int n, int min, int max)
{    
    var random = new Random();
    int[,] arr = new int[m, n];
    
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
    
    return arr;
}                               
 
void OutputTwoDimentionalArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int[,] SwapStringsInArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = temp;
    }
    return arr;
}

int m = InputNumberWithMessage("Input m: ");
int n = InputNumberWithMessage("Inout n: ");

int[,] arr = CreateTwoDimentionalArray(m, n, 0, 20);
OutputTwoDimentionalArray(arr);

Console.WriteLine();

arr = SwapStringsInArray(arr);
OutputTwoDimentionalArray(arr);
