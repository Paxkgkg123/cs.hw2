/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
    34, 5 -> не кратно, остаток 4
    16, 4 -> кратно
*/

int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int a = InputNumberWithMessage("Input 1 number: ");
int b = InputNumberWithMessage("Input 2 number: ");

if (a % b == 0)
    Console.WriteLine("Multiply");
else
    Console.WriteLine($"Not multiply, remainder of the division {a % b}");
