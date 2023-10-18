Random rng = new Random();

int number = rng.Next(100, 999);

int result = number / 10 % 10;

Console.WriteLine($"{number} - {result}");

//for (int i = 0; i < 100; i++) {
//    int number = rng.Next(100, 999);  

//    int result = number / 10 % 10;

//    Console.WriteLine($"{number} - {result}");
//}