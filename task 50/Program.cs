/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    1 7 -> такого числа в массиве нет
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

string FindElement(int[,] arr, int index0, int index1)
{
    if (index0 >= arr.GetLength(0) || index0 < 0)
        return "non";
    if (index1 >= arr.GetLength(1) || index1 < 0)
        return "non";
    
    return arr[index0, index1].ToString();
}

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}


void Circle(int[,] arr)
{
    Console.Clear();
    OutputTwoDimentionalArray(arr);
    
    Console.WriteLine("Input element's position: ");
    int index0 = InputNumberWithMessage("Horisonal: ");
    int index1 = InputNumberWithMessage("Vertical: ");
    
    string result = FindElement(arr, index0, index1);
    Console.WriteLine(result);
    
    Console.WriteLine("Put Enter if you want to continue, else put anything");
    string isContionue = Console.ReadLine();
    
    if (isContionue == "")
        Circle(arr);
}

int m = InputNumberWithMessage("Input m: ");
int n = InputNumberWithMessage("Input n: ");

int[,] arr = CreateTwoDimentionalDoubleArray(m, n, 0, 10);

Circle(arr);





