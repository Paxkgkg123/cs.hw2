/*
Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
сколько раз встречается элемент входных данных.
    Набор данных Частотный массив
    1, 2, 3
    4, 6, 1
    2, 1, 6
        \/
    1 встречается 3 раза
    2 встречается 2 раз
    3 встречается 1 раз
    4 встречается 1 раз
    6 встречается 2 раза
*/

int[,] CreatingArray()
{
    Console.Write("Input m: ");
    int m = int.Parse(Console.ReadLine());
    
    Console.Write("Input n: ");
    int n = int.Parse(Console.ReadLine());
    
    var random = new Random();
    int[,] arr = new int[m, n];
    
    int min = -20, max = 20;
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
    
    return arr;
}
    
void OutputTwoDimentionalArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

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
        if (first[f] < second[s])
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

int[,] arr = CreatingArray();
OutputTwoDimentionalArray(arr);

Console.WriteLine();

int[,] dict = Dictionary(arr);

Console.Out.NewLine = "раз\n";

OutputTwoDimentionalArray(dict);
