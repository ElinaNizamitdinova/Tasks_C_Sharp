// 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] Decrease(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = j;
            for (int k = j; k < arr.GetLength(1); k++)
            {

                if (arr[i, max] < arr[i, k])
                {
                    max = k;
                }

                int team = arr[i, max];
                arr[i, max] = arr[i, j];
                arr[i, j] = team;
            }
        }
    }
    return arr;
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
matrix=Decrease(matrix);
PrintArray(matrix);
Console.ReadKey();
