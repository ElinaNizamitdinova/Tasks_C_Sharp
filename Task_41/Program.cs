// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

double[] DoubleArray(int lengthArr)
{
    double[] array = new double[lengthArr];
    for (int i = 0; i < lengthArr; i++)
    {   Console.WriteLine($"Введите значение {i} элемента массива");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

int PositiveCounter(double[] Array){
    int count=0;
    for (int i = 0; i < Array.Length; i++)
    {
        if( Array[i]>0){
            count++;
            
        }
    }
    return count;
}
Console.WriteLine("Введите количество элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
double[] Array = DoubleArray(number);
int Count = PositiveCounter(Array);
Console.WriteLine(Count);
