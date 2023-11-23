/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(int size, int min, int max) {
    var random = new Random();
    
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) 
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void Output(int[] arr) {
    
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
}

int[] arr = CreateArray(5, -10, 10);

Output(arr);