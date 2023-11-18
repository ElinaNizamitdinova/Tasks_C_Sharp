// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] RandomArray(int sizeline, int sizecolumns)
{
    double[,] array = new double[sizeline, sizecolumns];
    for (int i = 0; i < sizeline; i++)
    {
        for (int j = 0; j < sizecolumns; j++)
        {
            Random rand = new Random();
            array[i, j] = rand.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Укажите размерность массива n * m");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double[,] Array = RandomArray(n, m);
PrintArray(Array);
Console.ReadKey();