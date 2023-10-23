// 39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 
// 1) менять числа местами в исходном массиве; 
// 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.

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




int[] ReversArray(int[] arr)
{
    int temp = 0;

    for (int i = 0; i < arr.Length/2; i++)
    {
       temp = arr[i];
       arr[i] = arr[arr.Length -i-1];
       arr[arr.Length -i-1] = temp;

    }
    return arr;
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
int[] Massiv = ReversArray(Mas);
Console.WriteLine("--------");
PrintArray(Massiv);


// void ReversArray(int[]array)
// {

//     int size = array.Length;
//     int reversindex= size - 1;
//     for (int i = 0; i < (size-1); i++)
//     {
        
    
//         if (size % 2 == 0)
//         {
//             while (i != (size %2))
//             {
//                 int timeValue = array[i];
//                 array[i] = array[reversindex];
//                 array[reversindex] = timeValue;
//                 reversindex=reversindex-1;
//             }
//         }
//         else
//         {
//             while (i != (size-1) / 2)
//             {
//                 int timeValue = array[i];
//                 array[i] = array[reversindex];
//                 array[reversindex] = timeValue;
//                 reversindex=reversindex-1;
//             }
//         }
       
//     }
//  PrintArray(array);

// }

// Console.Clear();
// int[] GetRandArray(int start, int end, int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(start, end + 1);
//     }
//     return array;
// }
// void PrintArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");
//     }
//     System.Console.Write("]");
//     System.Console.WriteLine();
// }

// int[] ReversArray(int[] arr)
// {
//     int temp = 0;

//     for (int i = 0; i < arr.Length/2; i++)
//     {
//        temp = arr[i];
//        arr[i] = arr[arr.Length -i-1];
//        arr[arr.Length -i-1] = temp;

//     }
//     return arr;
// }
// int[] userArray = GetRandArray(0, 10, 5);
// PrintArray(userArray);
// System.Console.WriteLine();
// int[] reversArray = ReversArray(userArray);
// PrintArray(reversArray);

