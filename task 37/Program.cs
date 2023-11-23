/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
второй и предпоследний и т.д. Результат запишите в новом массиве.
    [1 2 3 4 5] -> 5 8 3
    [6 7 3 6] -> 36 21
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
    Console.WriteLine();
}

int[] MultArray(int[] array)
{
    int[] result = new int[array.Length - array.Length / 2];
    int temp = 0;
    for (int i = 0; i < array.Length - array.Length / 2; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
            continue;
        }

        temp = array[i] * array[array.Length - 1 - i];
        result[i] = temp;
    }
    return result;
}

int[] array = CreateArray(8, 1, 5);
Output(array);
Console.WriteLine();
Output(MultArray(array));