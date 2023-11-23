/*
Выяснить является ли число чётным.
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int n = InputNumberWithMessage("Input number: ");

if (n % 2 == 0)
    Console.WriteLine("even");
else
    Console.WriteLine("not even");
