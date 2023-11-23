/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
*/

int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }
    return arr;
}

void Output(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

int Count(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i += 2)
        sum += arr[i];
    return sum;
}


int[] arr = CreateArray(6, -20, 20);
Output(arr);
System.Console.WriteLine(Count(arr));