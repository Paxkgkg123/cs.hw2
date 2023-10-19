/*
Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
*/
Console.Out.NewLine = " ";

Console.Clear();
Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; Math.Pow(i, 3) <= n; i++) {
    Console.WriteLine(Math.Pow(i, 3));
}
