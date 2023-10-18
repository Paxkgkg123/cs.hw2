Random rng = new Random();

int number = rng.Next(0, 100);
int result = number;

while (result >= 1000) {
    result = result / 10;
}

if (result >= 100) {
    result %= 10;
} else {
    result = -1;
}

if (result != -1) {
    Console.WriteLine($"{number} - {result}");
} else {
    Console.WriteLine($"{number} - 3-й цифры нет");    
}


//for (int i = 0; i < 30; i++) {
//    int number = rng.Next(0, 100000);
//    int result = number;

//    while (result >= 1000) {
//        result = result / 10;
//    }

//    if (result >= 100) {
//        result %= 10;
//    } else {
//        result = -1;
//    }

//    if (result != -1) {
//        Console.WriteLine($"{number} - {result}");
//    } else {
//        Console.WriteLine($"{number} - 3-й цифры нет");    
//    }
//}