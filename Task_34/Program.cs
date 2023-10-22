// Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
// Аргументы, передаваемые в метод/функцию:
// '124, 378, 593, 821, 456'
// Массив:
// 124     378     593     821     456 
// Количество четных элементов: 3
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

int EvenElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        };
    }
    return count;
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
int count = EvenElement(Mas);
Console.WriteLine("");
Console.WriteLine($"Количество четных элементов: {count}");