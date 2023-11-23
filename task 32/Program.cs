/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
отрицательные, и наоборот.
    [-4, -8, 8, 2] -> [4, 8, -8, -2]
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
    
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] ChangeArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] *= -1;
    }
    return arr;
}

int[] arr = CreateArray(10, -20, 20);

Output(arr);

int[] arr2 = ChangeArray(arr);
Console.WriteLine();

Output(arr2);