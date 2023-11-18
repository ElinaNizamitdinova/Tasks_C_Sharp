// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,,] Fill3DArray(int a, int b, int d, int minValue = 10)
{
    int[,,] array = new int[a, b, d];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < d; k++)
            {


                array[i, j, k] = minValue;
                minValue++;
            }
        }

    }
    return array;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {arr[i, j, k]} \t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Ведите параметр а ");
int userA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите параметр b ");
int userB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите параметр d ");
int userD = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = Fill3DArray(userA,userB,userD);
PrintArray(array3D);
Console.ReadKey();