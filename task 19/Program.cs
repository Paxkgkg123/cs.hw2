/*
Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
*/

int Revers(int number) {
    int revers = 0;
    while (number > 0) {
        revers = revers * 10 + number % 10;
        number /= 10;
    }
    return revers;
}

Console.Clear();
Console.Write("Input number: ");

int number = int.Parse(Console.ReadLine());
if (number == Revers(number)) {
    Console.WriteLine("This is a palindromic number");
} else {
    Console.WriteLine("This in not a palindromic number");
}
