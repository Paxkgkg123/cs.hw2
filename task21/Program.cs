/*
Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние
между ними в 3D пространстве.
*/
int[] Input(string massage) {
    Console.WriteLine(massage);
    int[] point = new int[3];
    string read = Console.ReadLine();
    string[] split = read.Split(new char[] {' '});
    for (int i = 0; i < 3; i++) {
        point[i] = int.Parse(split[i]);
    }
    return point;
}

double Length(int[] a, int[] b) {
    
    double l0 = Math.Pow(a[0] - b[0], 2);
    double l1 = Math.Pow(a[1] - b[1], 2);
    double l2 = Math.Pow(a[2] - b[2], 2);

    double result = Math.Sqrt(l0 + l1 + l2);
    return result;
    
}

Console.Clear();

int[] a = Input("Input first massage: ");
int[] b = Input("Input second coordinats: ");

double result = Length(a, b);

Console.WriteLine(result);
