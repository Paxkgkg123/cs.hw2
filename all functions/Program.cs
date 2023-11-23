                               
                               //ТРЕХМЕРНЫЙ МАССИВЫ//

// генерирует 3х мерный массив из неповторяющихся элементов                                
int[,,] Create3DNoRecurrungArray(int m, int n, int k, int min, int max)
{
    int[,,] arr = new int[m, n, k];
    int[] dictionary = new int[m * n * k];
    
    var random = new Random();
    
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int l = 0; l < k; l++)
            {
                int t = random.Next(min, max + 1);
                while (Find(dictionary, t) != -1)
                    t = random.Next(min, max);
                arr[i, j, l] = t;
                dictionary[i * n * k + j * k + l] = t;
            }
    
    OutputArray(dictionary);
    return arr;
}
    
// выводит в консоль 3х мерный массив                           
void Output3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        //Console.Write($"[{i}, ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine($"[{i}, {j}, ..]");
            
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                if (l == 0)
                    Console.Write("\t");
                Console.Write($"{arr[i, j, l]} ");
            }
            Console.WriteLine();
        }
    }
    
}
                          
                                //ДВУМЕРНЫЕ МАССИВЫ//
                                
// выводит в консоль двумерный массив -
void OutputTwoDimentionalArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

// ввод двумерного массива
int[,] InputTwoDimentionalArray(int m, int n)
{
    int[,] arr = new int[m, n];
    
    for (int i = 0; i < m; i++)
    {
        string str = Console.ReadLine();
        string[] tempArr = str.Split(" ");
        for (int j = 0; j < n; j++)
            arr[i, j] = int.Parse(tempArr[j]);
    }
    return arr;
}

// генерирует двумерный массив со значениями от min до max
int[,] CreateTwoDimentionalArray(int m, int n, int min, int max)
{    
    var random = new Random();
    int[,] arr = new int[m, n];
    
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
    
    return arr;
}                               
                    
// находит элемент массива, если позиции не верные, выводит non
string FindElement(int[,] arr, int index0, int index1)
{
    if (index0 >= arr.GetLength(0) || index0 < 0)
        return "non";
    if (index1 >= arr.GetLength(1) || index1 < 0)
        return "non";
    
    return arr[index0, index1].ToString();
}                

// построчно сортирует массив O(n^3)
int[,] SortTwoDementionalArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int l = 0; l < arr.GetLength(1) - 1 - j; l++)
                if (arr[i, l] < arr[i, l + 1])
                {
                    int temp = arr[i, l];
                    arr[i, l] = arr[i, l + 1];
                    arr[i, l + 1] = temp;
                }
    return arr;
}
    
// транспонирует матрицу, и выводит сообщение, если она не квадратная           
int[,] Transponing(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        Console.WriteLine("Impossible");
        return arr;
    }
    
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = i + 1; j < arr.GetLength(0); j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    
    return arr;
}

// запрашивает m и n, и создает рандомный двумерный массив
int[,] CreatingArray()
{
    Console.Write("Input m: ");
    int m = int.Parse(Console.ReadLine());
    
    Console.Write("Input n: ");
    int n = int.Parse(Console.ReadLine());
    
    var random = new Random();
    int[,] arr = new int[m, n];
    
    int min = 0, max = 20;
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
    
    return arr;
}
    
// составляет частотный словарь элементов
int[,] Dictionary(int[,] arr)
{
    int[] arr1D = new int[arr.GetLength(0) * arr.GetLength(1)];
    
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr1D[i * arr.GetLength(1) + j] = arr[i, j];
    
    arr1D = MergeSort(arr1D);
        
    int? lastNumber = null;
    int countNumbers = 0;
    
    for (int i = 0; i < arr1D.Length; i++)
        if (arr1D[i] != lastNumber)
        {
            lastNumber = arr1D[i];
            countNumbers++;
        }
    
    int[,] dict = new int[countNumbers, 2];
    
    lastNumber = null;
    for (int iArr = 0, iDict = 0; iArr < arr1D.Length && iDict < countNumbers; iArr++)
    {
        if (arr1D[iArr] == lastNumber)
        {            
            dict[iDict - 1, 1]++;
            continue;
        }
        
        dict[iDict, 0] = arr1D[iArr];
        dict[iDict, 1] = 1;
        iDict++;
        lastNumber = arr1D[iArr];
    }
        
    return dict;
}
    
// произведение матриц         
int[,] MatrixMulty(int[,] A, int[,] B)
{
    if (A.GetLength(1) != B.GetLength(0))
    {
        int[,] error = new int[0, 0];
        return error;
    }
    
    int[,] AB = new int[A.GetLength(0), B.GetLength(1)]; 
    
    for (int i = 0; i < A.GetLength(0); i++)
        for (int j = 0; j < B.GetLength(1); j++)
            for (int l = 0; l < A.GetLength(1); l++)
            {
                AB[i, j] += A[i, l] * B[l, j];
            }
    return AB;
}

// удаляет строчку и столбец минимального элемента
int[,] Basis(int[,] arr)
{
    int[,] minIndex = Min(arr);
        
    int[,] basis = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    
    for (int i = 0; i < basis.GetLength(0); i++)
        for (int j = 0; j < basis.GetLength(1); j++)
        {
            int arri = i, arrj = j;
            
            if (i >= minIndex[0, 0])
                arri++;
            if (j >= minIndex[0, 1])
                arrj++;
                
            basis[i, j] = arr[arri, arrj];
        }
    
    return basis;
}
 
                                //ОДНОМЕРНЫЕ МАСИИВЫ//

// Сортировка по убыванию O(nLogn)
int[] MergeSort(int[] arr)
{
    if (arr.Length == 1)
        return arr;
        
    int len = arr.Length / 2;
    
    int[] first = new int[len];
    for (int i = 0; i < len; i++)
        first[i] = arr[i];     
            
    int[] second = new int[arr.Length - len];
    for (int i = 0; i < arr.Length - len; i++)
        second[i] = arr[len + i];
     
    first = MergeSort(first);
    second = MergeSort(second);
    
    int[] sortArr = new int[arr.Length];
    
    int f = 0, s = 0;
    while (f < first.Length || s < second.Length)
    {
        if (f >= first.Length)
        {
            sortArr[f + s] = second[s++];
            continue;
        }
        if (s >= second.Length)
        {
            sortArr[f + s] = first[f++];
            continue;
        }
        if (first[f] > second[s])
        {
            sortArr[f + s] = first[f++];
        }
        else
        {
            sortArr[f + s] = second[s++];
        }
    }
    return sortArr;
}

// ввод через консоль одномерный массив
int[] InputArray()
{
    string s = Console.ReadLine();
    string[] split = s.Split(" ");
    int m = split.Length;
    int[] arr = new int[m];
    
    for (int i = 0; i < m; i++)
    {
        arr[i] = int.Parse(split[i]);
    }
    
    return arr;
}

// создает одномерный массив 
int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }
    return arr;
}

// Выводит в консоль одномерный массив
void OutputArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

// копирует одномерный масив
int[] CopyArray(int[] arr)
{
    int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        copy[i] = arr[i];
    
    return copy;
}

// находит n чисел фибаначи
int[] Fib(int n)
{
    int[] numbers = new int[n];
    numbers[0] = 0;
    numbers[1] = 1;
    for (int i = 2; i < n; i++)
        numbers[i] = numbers[i - 1] + numbers[i - 2];
    return numbers;
}

// находит перный элемент равнфй заданнному, выводит индекс или -1, если элемента нет
int Find(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == number)
            return i;
    
    return -1;
}

// находит сумму элементов в массиве
int Sum(int[] arr)
{
    int sum = 0;
    
    for (int i = 0; i < arr.Length; i++)
        sum += arr[i];
        
    return sum;
}


                                        //ЧИСЛА//

// выводит сообщение и читает из консоли число
int InputNumberWithMessage(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

// генерирует число от min до max
int RandomNumber(int min, int max)
{
    var random = new Random();
    
    int n = random.Next(min, max);
    return n;
}

// находит максимальную цифру в числе
int MaxDigit(int number)
{
    int max = 0;
    
    while (number > 0)
    {
        if (number % 10 > max)
            max = number % 10;
        number /= 10;
    }
    return max;
}

// находин определенную цифру числа
int SearchDigit(int number, int digitOfNumber)
{    
    int digit = -1;
    for (int r = number; r >= Math.Pow(10, digitOfNumber - 1); r /= 10)
        digit = r % 10;
    
    return digit;
}

// разворачивает цифры в числе
int Revers(int number) {
    int revers = 0;
    while (number > 0) {
        revers = revers * 10 + number % 10;
        number /= 10;
    }
    return revers;
}






