Random rng = new Random();

int n = rng.Next(1, 9);
Console.WriteLine(n);

if (n < 1 || n > 7) {
    Console.WriteLine("Такого числа нет");
}
if (n >= 1 && n <= 5) {
    Console.WriteLine("Будний день");
}
if (n >= 6 && n <= 7) {
    Console.WriteLine("Выходной");
}