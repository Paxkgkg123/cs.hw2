/*
Заполните спирально массив 4 на 4.
    1 2 3 4
    12 13 14 5
    11 16 15 6
    10 9 8 7
*/

int[,] GenerArray(int m, int n, int i = 0, int j = 0, int count = 1, int derection = 0, int[] array = new int[1] {0})
{
    if (count == 1)
    {
        int arr = new int[m, n];
        arr[i, j] = count + 1;
        return GenerArray(m, n, i, j, count + 1, 0, arr);
    }
    
    
    
    
        
    if (count == m * n)
        return arr;
}

for (int i = 0, j = 0, count = 1; count <= 16; count++)
{
    if (j + 1 == 4 ||)    
}


