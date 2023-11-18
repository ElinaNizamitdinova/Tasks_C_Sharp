Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

void  AToTheBPower(int a, int b,int value)
{
    if (b > 1){
        value *= a;
        AToTheBPower(a, b - 1,value);
    }
    else{
        Console.WriteLine(value);
    }

}
AToTheBPower(numberA, numberB,numberA);
Console.ReadKey();