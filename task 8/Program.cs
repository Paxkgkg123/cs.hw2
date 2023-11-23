/*
Показать чётные числа от 1 до N.
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int n = InputNumberWithMessage("Inpun N: ");

for (int i = 2; i <= n; i += 2)
    Console.Write($"{i} ");
    