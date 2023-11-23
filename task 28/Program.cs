/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
    4 -> 24
    5 -> 120
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int Multiply(int n)
{
    int multy = 1;
     for (int i = 1; i <= n; i++)
        multy *= i;
    
    return multy;
}

int n = InputNumberWithMessage("Input n: ");

int multy = Multiply(n);

Console.WriteLine(multy);
