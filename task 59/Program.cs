/*
Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Наименьший элемент - 1, на выходе получим
    следующий массив:
    9 4 2
    2 2 6
    3 4 7
*/

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
 
void OutputTwoDimentionalArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] Min(int[,] arr)
{
    int[,] minIndex = new int[1, 2] {{0, 0}};
    int min = arr[0, 0];
    
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minIndex[0, 0] = i;
                minIndex[0, 1] = j;
            }
    
    return minIndex;
}

int[,] Basis(int[,] arr)
{
    int[,] minIndex = Min(arr);
        
    int[,] basis = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    
    for (int i = 0; i < basis.GetLength(0); i++)
        for (int j = 0; j < basis.GetLength(1); j++)
        {
            int arri = i, arrj = j;
            
            if (i >= minIndex[0, 0])
                arri++;
            if (j >= minIndex[0, 1])
                arrj++;
                
            basis[i, j] = arr[arri, arrj];
        }
    
    return basis;
}

int[,] arr = CreatingArray();

OutputTwoDimentionalArray(arr);

Console.WriteLine();

int[,] basis = Basis(arr);

OutputTwoDimentionalArray(basis);

