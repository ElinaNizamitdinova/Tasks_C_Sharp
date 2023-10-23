// 37. Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
using System.Diagnostics;
using System.Xml.XPath;

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



int[] ProductArray(int[] array)
{   int count =0;
    if(array.Length%2!=0){
        count= array.Length/2+1;
    }
    else{
        count= array.Length/2;
    }
    int[] newArray = new int[count];
    if (array.Length%2!=0){
        newArray[count-1]=array[count-1];}
    
    for (int i = 0; i < array.Length/2; i++)
    {
        int product = array[i] * array[array.Length - 1 - i];
        newArray[i] = product;
    }

    return newArray;
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
Console.WriteLine("");
int[] NewMas = ProductArray(Mas);
PrintArray(NewMas);


