/*
Задача 45: Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.
*/

int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void Output(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] Copy(int[] arr)
{
    int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        copy[i] = arr[i];
    
    return copy;
}

int[] arr = CreateArray(10, 0, 20);
int[] copy = Copy(arr);
Output(arr);
Output(copy);