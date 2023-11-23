/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int SearchDigit(int number, int digitOfNumber)
{    
    int digit = -1;
    for (int r = number; r >= Math.Pow(10, digitOfNumber - 1); r /= 10)
        digit = r % 10;
    
    return digit;
}

int number = InputNumberWithMessage("Input number: ");
int digit = SearchDigit(number, 1);
Console.WriteLine(digit); 
