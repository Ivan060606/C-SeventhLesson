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

Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] mas = FillArray(m,n);
PrintArray(mas);
Console.WriteLine();


Console.Write("Введите строку нужного элемента: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец нужного элемента: ");
int l = Convert.ToInt32(Console.ReadLine());
if (k<m+1 && l<n+1) Console.Write($"{mas[k,l]}");
else Console.Write("Нет нужного элемента.");