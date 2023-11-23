/*
Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
*/

int[,] CreatingArray()
{
    Console.Write("Input m: ");
    int m = int.Parse(Console.ReadLine());
    
    Console.Write("Input n: ");
    int n = int.Parse(Console.ReadLine());
    
    var random = new Random();
    int[,] arr = new int[m, n];
    
    int min = -20, max = 20;
    
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

int MinSum(int[,] arr)
{
    int minSum = 0;
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            sum += arr[i, j];
        
        if (i == 0 || sum < minSum)
            minSum = sum;
    }
    
    return minSum;
}

int[,] arr = CreatingArray();
OutputTwoDimentionalArray(arr);

Console.WriteLine(MinSum(arr));

