void PrintArray(int [,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write(table[i,j] + " ");
    }
    Console.WriteLine();
}
}

int [,] FillArray (int m, int n)
{
int [,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(1, 100);
    }   
}
return array;
}

int [] FillArrayForSum (int [,] arr1, int n, int m)
{
int [] arr = new int [n];
for (int j = 0; j < /*arr1.*/n/*GetLength(1)*/; j++)
{
    int sum = 0;
    for (int i = 0; i < /*arr1.*/m/*GetLength(0)*/; i++)
    {
        sum = sum + arr1[i,j];
    }
    arr[j] = sum;
}
return arr;
}


Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] mas = FillArray(m,n);
PrintArray(mas);

Console.WriteLine();
FillArrayForSum(mas, n, m);