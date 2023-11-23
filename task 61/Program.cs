/*
Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/

void OutputArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] TriangleOfPascal(int n, int k = 0)
{
    if (n == 1)
    {
        for (int i = 0; i < k; i++)
            Console.Write(" ");
        Console.WriteLine("1");
        return new int[1] {1};
    }
    
    int[] lastLine = TriangleOfPascal(n - 1, k + 1);
    
    int[] line = new int[lastLine.Length + 1];
    
    line[0] = 1;
    line[line.Length - 1] = 1;
    for (int i = 0; i < lastLine.Length - 1; i++)
        line[i + 1] = lastLine[i] + lastLine[i + 1];
    
    for (int i = 0; i < k; i++)
        Console.Write(" ");
            
    OutputArray(line);
    
    return line;
}

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int n = InputNumberWithMessage("Input n: ");

TriangleOfPascal(n);
