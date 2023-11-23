/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
    m = 3, n = 4.
    0 1 2 3
    1 2 3 4
    2 3 4 5
*/

int[,] GenerArr(int m, int n)
{
    int[,] arr = new int[m,n];
    for (int j = 0; j < m; j++)
        for (int i = 0; i < n; i++)
            arr[j,i] = j + i;
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

Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());

int[,] arr = GenerArr(m, n);

OutputTwoDimentionalArray(arr);