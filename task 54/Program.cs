/*
Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] SortTwoDementionalArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int l = 0; l < arr.GetLength(1) - 1 - j; l++)
                if (arr[i, l] < arr[i, l + 1])
                {
                    int temp = arr[i, l];
                    arr[i, l] = arr[i, l + 1];
                    arr[i, l + 1] = temp;
                }
    return arr;
}


int m = InputNumberWithMessage("Input m: ");
int n = InputNumberWithMessage("Input n: ");

int[,] arr = CreateTwoDimentionalArray(m, n, 0, 20);
OutputTwoDimentionalArray(arr);

Console.WriteLine();

arr = SortTwoDementionalArray(arr);
OutputTwoDimentionalArray(arr);

