/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.*/



int[] GetNewArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i<size;i++ )
    {
        array[i]=new Random().Next(-9,10);
        Console.WriteLine(array[i]);

    }

    return array;
}


int PositiveSum(int size,int[]array)
{
     int Summ = 0;
    for(int i = 0; i<size;i++){
        if (array[i]>0){
            Summ=Summ+array[i];
        };
        }
    
    return(Summ);
}


int NegativeSum(int size,int[]array)
{
     int Summ = 0;
    for(int i = 0; i<size;i++){
        if (array[i]<0){
            Summ=Summ+array[i];
        };
        }
    
    return(Summ);
}
Console.WriteLine("Введите количество элементов в массиве");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------");
int[] newArray = GetNewArray(size);
int sumOfPositive=PositiveSum(size,newArray);
int sumOfNegative = NegativeSum(size,newArray);
Console.WriteLine("-------");
Console.WriteLine($"сумма положительных чисел равна {sumOfPositive}, сумма отрицательных равна {sumOfNegative}");
