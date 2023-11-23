/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
    46 -> нет
    161 -> да
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int n = InputNumberWithMessage("Input number: ");

if (n % (7 * 23) == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
