/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] -> +29, -20
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
    Console.WriteLine();
}

void FindPluse(int[] arr) {
    int sum = 0;
    
    foreach (var i in arr) {
        if (i >= 0) {
            sum += i;
        }
    }
    Console.WriteLine("+" + sum);  
}

void FindMinus(int[] arr) {
    int sum = 0;
    foreach (var i in arr) {
        if (i < 0) {
            sum += i;
        }
    }
    Console.WriteLine(sum);
}

int[] arr = CreateArray(4, -21, 10);
Output(arr);

FindMinus(arr);
FindPluse(arr);