// 50.
//Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
using System.Threading.Tasks.Sources;

int[,] CreateIncereasingArray(int sizeline, int sizecolumns, int elemDiff)
{
    int[,] array = new int[sizeline, sizecolumns];
    int initialValue = 0;
    for (int i = 0; i < sizeline; i++)
    {
        for (int j = 0; j < sizecolumns; j++)
        {
            initialValue += elemDiff;
            array[i, j] = initialValue;
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

Console.WriteLine("Введите количество строк и столбцов");
int lineSize = Convert.ToInt32(Console.ReadLine());
int columnSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите разницу между каждым элементом массива");
int diff= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента i, j");
int j = Convert.ToInt32(Console.ReadLine());
int i = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = CreateIncereasingArray(lineSize,columnSize,diff);
PrintArray(randomArray);
void FindNumderByPosition(int[,] arr, int valueI, int valueJ)
{
    if (valueI >= arr.GetLength(0) || valueJ >= arr.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    if (valueI < arr.GetLength(0) && valueJ < arr.GetLength(1))
    {
        Console.WriteLine($"Элемент равен {arr[valueI, valueJ]}");
    }
}
FindNumderByPosition(randomArray,i,j);
Console.ReadKey();