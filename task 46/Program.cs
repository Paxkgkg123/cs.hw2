/*
Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int[,] InputArray(int m, int n)
{
    int[,] arr = new int[m, n];
    
    for (int i = 0; i < m; i++)
    {
        string str = Console.ReadLine();
        string[] tempArr = str.Split(" ");
        for (int j = 0; j < n; j++)
            arr[i, j] = int.Parse(tempArr[j]);
    }
    return arr;
}

void Output(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] arr = InputArray(2, 3);
Output(arr);