/*
Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int[] Fib(int n)
{
    int[] numbers = new int[n];
    numbers[0] = 0;
    numbers[1] = 1;
    for (int i = 2; i < n; i++)
        numbers[i] = numbers[i - 1] + numbers[i - 2];
    return numbers;
}

void Output(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());

Output(Fib(n));