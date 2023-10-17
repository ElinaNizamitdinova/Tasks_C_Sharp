// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке


int[] RandomArray(int size)
{
int[] array= new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 2);
}
return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
}
int[] UserA = RandomArray(9);
PrintArray(UserA);