/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

int[,,] Create3DArray(int m, int n, int k, int min, int max)
{
    int[,,] arr = new int[m, n, k];
    int[] dictionary = new int[m * n * k];
    
    var random = new Random();
    
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int l = 0; l < k; l++)
            {
                int t = random.Next(min, max + 1);
                while (Find(dictionary, t) != -1)
                    t = random.Next(min, max);
                arr[i, j, l] = t;
                dictionary[i * n * k + j * k + l] = t;
            }
    
    OutputArray(dictionary);
    return arr;
}

int Find(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == number)
            return i;
    
    return -1;
}

void Output3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        //Console.Write($"[{i}, ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine($"[{i}, {j}, ..]");
            
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                if (l == 0)
                    Console.Write("\t");
                Console.Write($"{arr[i, j, l]} ");
            }
            Console.WriteLine();
        }
    }
    
}

void OutputArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[,,] arr = Create3DArray(2, 2, 5, 10, 99);

Output3DArray(arr);