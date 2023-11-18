Console.Clear();

int[,] RandomArray(int sizeline, int sizecolumns, int maxValue=10, int minValue=1)
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

(int, int) FindMinIndex(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}

int[,] DeleteMinColumnRow(int[,] array, int row, int column)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int x = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == row)
        {
            row = -1;
            continue;
        }
        int y = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == column) continue;
            result[x, y] = array[i, j];
            y++;
        }
        x++;
    }
    return result;
}





Console.WriteLine("Ведите количество строк ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество столбцов ");
int userColumn = Convert.ToInt32(Console.ReadLine());
int[,] userArray = RandomArray(userRow, userColumn);
PrintArray(userArray);
(int minRow, int minColumn) = FindMinIndex(userArray);
int[,] newArray = DeleteMinColumnRow(userArray, minRow, minColumn);
System.Console.WriteLine();
PrintArray(newArray);
Console.ReadKey();