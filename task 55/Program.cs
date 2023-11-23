/*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для пользователя.
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

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

int[,] Transponing(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        Console.WriteLine("Impossible");
        return arr;
    }
    
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = i + 1; j < arr.GetLength(0); j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    
    return arr;
}

int[,] CreatingArray()
{
    Console.Write("Input m: ");
    int m = int.Parse(Console.ReadLine());
    
    Console.Write("Input n: ");
    int n = int.Parse(Console.ReadLine());
    
    var random = new Random();
    int[,] arr = new int[m, n];
    
    int min = 0, max = 20;
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
    
    return arr;
}


int[,] arr = CreatingArray();
OutputTwoDimentionalArray(arr);

Console.WriteLine();

OutputTwoDimentionalArray(Transponing(arr));

