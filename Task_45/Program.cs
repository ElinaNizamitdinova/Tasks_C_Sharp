//45. Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.

int[] RandomArray(int size, int maxValue, int minValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
}
int[] CopyArray(int[] arr)
{   int[] array = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        array[i]=arr[i];
    }
    return array;
}

Console.WriteLine("Введите количество элементов в массиве");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение в массиве");
int maxi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение в массиве");
int mini = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------");
int[] Mas = RandomArray(size, maxi, mini);
PrintArray(Mas);
int[] Massiv = CopyArray(Mas);
Console.WriteLine();
Console.WriteLine("--------");
PrintArray(Massiv);
Console.ReadKey();
