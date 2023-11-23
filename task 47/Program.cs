/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/

double[,] CreateTwoDimentionalDoubleArray(int m, int n, int min, int max)
{
    var random = new Random();
    double[,] arr = new double[m, n];
    
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.NextDouble() * (max - min) + min;
        }
    }
    
    return arr;
}

void OutputTwoDimentionalDoubleArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

double CutDouble(double number, int countDigit)
{
    double a = number % Math.Pow(10, -countDigit + 1);
    double d = a % Math.Pow(10, -countDigit);
    
    return number - d;
}

double[,] arr = CreateTwoDimentionalDoubleArray(4, 2, -10, 10);

OutputTwoDimentionalDoubleArray(arr);