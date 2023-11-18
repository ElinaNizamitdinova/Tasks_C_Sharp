//58 : Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
using System.Linq.Expressions;

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

int[,] ProductOfMatrix(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            newArray[i, j] = (array1[i, j] * array2[i, j]);
        }


    }
    return newArray;
}

Console.WriteLine("Введите количество колон и строк в первом массиве");
int countcolumn1 = Convert.ToInt32(Console.ReadLine());
int countline1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите минимум и максимум диапозона в первом массиве");
int minimum1 = Convert.ToInt32(Console.ReadLine());
int maximum1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество колон и строк в первом массиве");
int countcolumn2 = Convert.ToInt32(Console.ReadLine());
int countline2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите минимум и максимум диапозона в первом массиве");
int minimum2 = Convert.ToInt32(Console.ReadLine());
int maximum2 = Convert.ToInt32(Console.ReadLine());
int[,] matrixNew = new int[countcolumn1, countcolumn1];
if (countcolumn1 != countcolumn2 || countline1 != countline2)
{
    Console.WriteLine("Ошибка, размерность массиовов не совпадает");
    Console.ReadKey();
}
else
{
    int[,] matrix1 = RandomArray(countline1, countcolumn1, maximum1, minimum1);
    int[,] matrix2 = RandomArray(countline2, countcolumn2, maximum2, minimum2);
    matrixNew = ProductOfMatrix(matrix1, matrix2);
    PrintArray(matrix1);
    Console.WriteLine("--------");
    PrintArray(matrix2);
    Console.WriteLine("--------");
    PrintArray(matrixNew);
    Console.ReadKey();
}
