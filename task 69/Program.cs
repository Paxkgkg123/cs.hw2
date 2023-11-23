/*
Напишите программу, которая принимает на вход 2 числа А и В, и возводит А в степень В.
    2 3 -> 8
 */
 
int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int Pow(int A, int B, int multy = 1)
{
    if (B == 0)
        return multy;
        
    return Pow(A, B - 1, multy * A);
}

int A = InputNumberWithMessage("Input A: ");
int B = InputNumberWithMessage("Input B: ");

Console.Write(Pow(A, B));
