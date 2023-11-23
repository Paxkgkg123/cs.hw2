/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateTwoDimentionalDoubleArray(int m, int n, int min, int max)
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

void OutputDoubleArray(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] ExternalArithmetic(int[,] arr)
{
    double[] externalArithmetic = new double[arr.GetLength(1)];
    
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
            sum += arr[j, i];
        externalArithmetic[i] = sum / arr.GetLength(0);
    }
    
    return externalArithmetic;
}

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int m = InputNumberWithMessage("Input m: ");
int n = InputNumberWithMessage("Input n: ");

Console.WriteLine();

int[,] arr = CreateTwoDimentionalDoubleArray(m, n, 0, 20);
OutputTwoDimentionalArray(arr);

Console.WriteLine();

double[] externalArithmetic = ExternalArithmetic(arr);
OutputDoubleArray(externalArithmetic);

