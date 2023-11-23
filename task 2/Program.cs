/*
Задача 2: Даны два числа. Показать большее и меньшее число.
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int a = InputNumberWithMessage("Input first number: ");
int b = InputNumberWithMessage("Input second number: ");

if (a > b)
{
    Console.WriteLine($"{a} > {b}");
}
if (a == b)
{
    Console.WriteLine($"{a} == {b}");
}
if (a < b)
{
    Console.WriteLine($"{a} < {b}");
}