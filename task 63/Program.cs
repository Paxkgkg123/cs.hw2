/*
Вывести все натуральные числа от 1 до N
    5 -> 1 2 3 4 5
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

void OutputNumbers(int n)
{
     if (n != 1)
     {
        OutputNumbers(n - 1);
     }
     
     Console.Write($"{n} ");
     
}

int n = InputNumberWithMessage("Input n: ");

OutputNumbers(n);