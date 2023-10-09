
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int maximal = a;
if (maximal < b)
{
    maximal = b;
}
if (maximal < c)
{
    maximal = c;
}
System.Console.Write("Максимальное число из трех  ");
System.Console.Write(maximal);


