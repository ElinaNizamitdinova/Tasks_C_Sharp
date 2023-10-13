Console.WriteLine("Введите число A");
int NumderA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B, предпологаемый квадрат числа A");
int NumberB = Convert.ToInt32(Console.ReadLine());
if(NumderA*NumderA==NumberB)
{
    Console.Write("Верно, число В является квадратом числа А");
}
else
{
    Console.Write("Нет, число В не является квадратом числа А");
}




