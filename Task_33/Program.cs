//  Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] GetNewArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 3);

    }

    return array;
}


void Presence(int size, int[] array, int number)
{
    for (int i = 0; i < size; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine("Yes");
            return;
        }
        
    }
    Console.WriteLine("No");
}

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int[] Array = GetNewArray(size);

Presence(size, Array, Number);

