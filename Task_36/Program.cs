// 36. Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".
// Аргументы, передаваемые в метод/функцию:
// '18, 76, 11'
// На выходе:
// 18      76      11  
// Сумма нечетных элементов: 76


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

int SummOfNegstive(int[] array, int size )
{ 
    int Summ = 0;
    for (int i = 1; i <= size-1; i=i+2)
    {
        Summ =Summ + array[i];
    }
    return Summ;
}
Console.WriteLine("Введите количество элементов в массиве");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение в массиве");
int maxi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное значение в массиве");
int mini = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------");
int[] Mas = RandomArray(size,maxi,mini);
PrintArray(Mas);
int summ = SummOfNegstive(Mas,size);
Console.WriteLine("");
Console.WriteLine($"Сумма нечетных элементов: {summ}");