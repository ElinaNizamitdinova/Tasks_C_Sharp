Console.Clear();

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());



void IntSumm(int numM,int numN,int summ)
{
    if (numM <= numN)
    {   
        summ = summ+ numM;
    
        IntSumm(numM+1,numN,summ);
    }
    if(numM==numN){
        Console.Write($"=> {summ}");
    }
}
Console.Write($"M:{numberM},N:{numberN}");
int summ=0;
IntSumm(numberM,numberN,summ);

Console.ReadKey();
