/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементов массива.
*/

double[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.NextDouble() * (max - min) - Math.Abs(min);
        arr[i] -= arr[i] % 0.001;
    }
    return arr;
}

void Output(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

double Diapasone(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
            
        if (arr[i] < min)
            min = arr[i];
    }
    return max - min;
}


double[] arr = CreateArray(6, -20, 20);
Output(arr);
System.Console.WriteLine(Diapasone(arr));