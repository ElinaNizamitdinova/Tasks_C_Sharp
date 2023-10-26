int[,] RandomArray(int sizeline, int sizecolumns, int maxValue, int minValue)
{
    int[,] array = new int[sizeline, sizecolumns];
    for (int i = 0; i < sizeline; i++)
    {
        for (int j = 0; j < sizecolumns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
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

int DiagonalSumm(int[,] arr)
{
    int Summ = 0;
    for (int i = 0; i < arr.GetLength(0); i ++)
    {
        Summ += arr[i, i];

    }
    return Summ;
}

Console.WriteLine("Введите количество элементов в массиве");
int sizeline = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов в массиве");
int sizecolumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение в массиве");
int maxi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение в массиве");
int mini = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------");
int[,] Userarray = RandomArray(sizeline, sizecolumns, maxi, mini);
PrintArray(Userarray);
Console.WriteLine("-------");
int summDiagonal= DiagonalSumm(Userarray);
Console.WriteLine(summDiagonal);
Console.ReadKey();
