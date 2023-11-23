/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
    1 4 7 2  ->  1 4 7 2
    5 9 2 3  ->  5 81 2 9
    8 4 2 4  ->  8 4 2 4
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

int[,] ChangeTwoDimentionalArray(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i += 2)
        for (int j = 1; j < arr.GetLength(1); j += 2)
            arr[i, j] *= arr[i, j];
    
    return arr;
}

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int m = InputNumberWithMessage("Input m: ");
int n = InputNumberWithMessage("Input n: ");
int min = InputNumberWithMessage("Input min: ");
int max = InputNumberWithMessage("Input max: ");

int[,] arr = CreateTwoDimentionalDoubleArray(m, n, min, max);
OutputTwoDimentionalArray(arr);

Console.WriteLine();

int[,] resultArr = ChangeTwoDimentionalArray(arr);
OutputTwoDimentionalArray(resultArr);


