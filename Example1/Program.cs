void PrintArray(double [,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write(table[i,j] + "\t");
    }
    Console.WriteLine();
}
}

double [,] FillArray (int m, int n)
{
double [,] array = new double [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(-99,100) + (Math.Round(new Random().NextDouble(), 2, MidpointRounding.AwayFromZero));
    }    
}
return array;
}

Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double [,] arr = FillArray(m,n);
PrintArray(arr);