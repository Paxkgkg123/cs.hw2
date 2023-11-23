/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
*/

int Accerman(int m, int n)
{
    if (m == 0)
        return n + 1;
        
    if (n == 0)
        return Accerman(m - 1, 1);
        
    return Accerman(m - 1, Accerman(m, n - 1));
}

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int main()
{
    Console.WriteLine("Continue - Enter; end - any key");
    string isEnter = Console.ReadLine();
    if (isEnter != "")
        return 0;
        
    int m = InputNumberWithMessage("Input m: ");
    int n = InputNumberWithMessage("Input n: ");

    if (m < 0)
        Console.Write("m < 0 ");
        
    if (n < 0)
        Console.WriteLine("n < 0");
        
    if (n >= 0 && m >= 0)
        Console.WriteLine(Accerman(m, n));
    
    return main();
}

main();