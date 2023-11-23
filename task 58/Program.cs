/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

int[,] CreatingArray()
{
    Console.Write("Input m: ");
    int m = int.Parse(Console.ReadLine());
    
    Console.Write("Input n: ");
    int n = int.Parse(Console.ReadLine());
    
    var random = new Random();
    int[,] arr = new int[m, n];
    
    int min = 0, max = 10;
    
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

int[,] MatrixMulty(int[,] A, int[,] B)
{
    if (A.GetLength(1) != B.GetLength(0))
    {
        int[,] error = new int[0, 0];
        return error;
    }
    
    int[,] AB = new int[A.GetLength(0), B.GetLength(1)]; 
    
    for (int i = 0; i < A.GetLength(0); i++)
        for (int j = 0; j < B.GetLength(1); j++)
            for (int l = 0; l < A.GetLength(1); l++)
            {
                AB[i, j] += A[i, l] * B[l, j];
            }
    return AB;
}

int[,] A = CreatingArray();
int[,] B = CreatingArray();

OutputTwoDimentionalArray(A);

Console.WriteLine();

OutputTwoDimentionalArray(B);

Console.WriteLine();

int[,] AB = MatrixMulty(A, B);

OutputTwoDimentionalArray(AB);

