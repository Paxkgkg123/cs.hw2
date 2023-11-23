/*
Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали с индексами (0,0); (1;1) и т.д.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Сумма элементов главной диагонали: 1+9+2 = 12
*/

int[,] CreateTwoDimentionalDoubleArray(int min, int max)
{
    Console.Write("Input m: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Input n: ");
    int n = int.Parse(Console.ReadLine());
    
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

int DiagonalSum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0) && i < arr.GetLength(1); i++)
        sum += arr[i, i];
    
    return sum;
}

int[,] arr = CreateTwoDimentionalDoubleArray(0, 20);
OutputTwoDimentionalArray(arr);

Console.WriteLine(DiagonalSum(arr));

