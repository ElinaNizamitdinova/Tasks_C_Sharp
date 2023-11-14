// 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

void PrintCount (int[,] array)
{
    for (int k = 0; k <= FindMax(array); k++)
    {
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
           if(k == array[i,j]) count ++;
        }
    }
    System.Console.WriteLine($"Число {k} встречается {count} разa.");
    }
}

int FindMax(int[,] array)
{
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] > max) max = array[i,j];
        }
    }
    return max;
}


Console.WriteLine("Введите количество колон и строк");
int countcolumn = Convert.ToInt32(Console.ReadLine());
int countline = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число диапазона");
int userArrayStart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число диапазона");
int userArrayEnd = Convert.ToInt32(Console.ReadLine());
int[,] ArrayUser = RandomArray(countline, countcolumn, userArrayStart, userArrayEnd);
PrintArray(ArrayUser);
PrintCount(ArrayUser);
Console.ReadKey();