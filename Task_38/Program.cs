// 38. Напишите программу для работы с массивом вещественных чисел.
// Аргументы, передаваемые в метод/функцию:
// '3.17, 8.94, 2.36, 5.72, 0.85'
// На выходе:
// Массив:
// 3.17    8.94    2.36    5.72    0.85    
// 8.09

double[] DoubleArray()
{
    double[] array = new double[5];
    for (int i = 0; i < 5; i++)
    {   Console.WriteLine($"Введите значение {i} элемента массива");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}



void Difference(double[] arr)
{   double max = arr[0];
    double min = arr[0];
    
    for (int i = 1; i < 5; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"Разность между максимальным и минимальным элементом = {max-min}");

}
double[] Mas = DoubleArray();
Difference(Mas);