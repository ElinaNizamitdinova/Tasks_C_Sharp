// 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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
void MinimumLineSum(int[,] arr)
{
    int realMinSum = 0;
    int indexLine = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i, j];

        }
        if (summ < realMinSum)
        {
            realMinSum = summ;
            indexLine = i;
        }
        if (i == 0)
        {
            realMinSum = summ;

        }

    }
    Console.WriteLine($"Индекс строки с минимальной суммой {indexLine}");
}
Console.WriteLine("Введите количество колон и строк");
int countcolumn = Convert.ToInt32(Console.ReadLine());
int countline = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите минимум и максимум диапозона");
int minimum = Convert.ToInt32(Console.ReadLine());
int maximum = Convert.ToInt32(Console.ReadLine());
int[,] matrix = RandomArray(countline, countcolumn, maximum, minimum);
PrintArray(matrix);
Console.WriteLine("-----------");
MinimumLineSum(matrix);
Console.ReadKey();

