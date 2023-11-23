/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
78 -> 8
*/

int RandomNumber(int min, int max)
{
    var random = new Random();
    
    int n = random.Next(min, max);
    return n;
}

int MaxDigit(int number)
{
    int max = 0;
    
    while (number > 0)
    {
        if (number % 10 > max)
            max = number % 10;
        number /= 10;
    }
    return max;
}

int number = RandomNumber(10, 99999);
int digit = MaxDigit(number);

Console.WriteLine($"Number: {number}");
Console.WriteLine($"Digit: {digit}");