Console.Clear();

int[] GetNewArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i<size;i++ )
    {
        array[i]=new Random().Next(0,100);

    }

    return array;
}

void WriteArray(int size,int[]array){
    for(int i = 0; i<size;i++){
        Console.Write($"{array[i]},");
    }

}
Console.WriteLine("Введите желаймую длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] NewArray= GetNewArray(size);
WriteArray(size,NewArray);