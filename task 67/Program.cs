/*
Вывести сумму цифр в числе.
    123 -> 6
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int SumDigits(int number, int sum = 0)
{
    if (number > 0)
    {
        sum = SumDigits(number / 10, sum + number % 10);
    }
    return sum;
}

int number = InputNumberWithMessage("Input number: ");

Console.WriteLine(SumDigits(number));