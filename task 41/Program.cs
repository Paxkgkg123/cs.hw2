/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] Input(int m)
{
    int[] arr = new int[m];
    string s = Console.ReadLine();
    string[] split = s.Split(" ");
    
    for (int i = 0; i < m; i++)
    {
        arr[i] = int.Parse(split[i]);
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
    int count = 0;
    
    foreach (var item in arr)
    {
        if (item > 0)
            count++;
    }
    return count;
}

int m = int.Parse(Console.ReadLine());
int[] arr = Input(m);
Console.WriteLine(Count(arr));