// 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.


int[,] FillArray(int sizeline, int sizecolumns)
{
    int[,] array = new int[sizeline, sizecolumns];
    for (int i = 0; i < sizeline; i++)
    {
        for (int j = 0; j < sizecolumns; j++)
        {
            array[i, j] = Convert.ToInt32(Console.ReadLine());
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

void Mean(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double summ = 0;
        double count = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[j, i];
            count++;
        }
        double mean = summ / count;
        Console.Write($"{mean}; ");
    }
}
Console.WriteLine("Введите количество столбцов и строк в массиве");
int sizecolumns = Convert.ToInt32(Console.ReadLine());
int sizeline = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заполните массив");
int[,] Userarray = FillArray(sizeline, sizecolumns);
Console.WriteLine("----------");
PrintArray(Userarray);
Console.WriteLine("Среднее арифметическое каждого столбца по очереди");
Mean(Userarray);
Console.ReadKey();