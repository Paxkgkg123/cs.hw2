/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
    5 -> 1, 4, 9, 16, 25.
    2 -> 1,4
*/
Console.Out.NewLine = " ";

Console.Clear();
Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; Math.Pow(i, 2) <= n; i++) {
    Console.WriteLine(Math.Pow(i, 2));
}
