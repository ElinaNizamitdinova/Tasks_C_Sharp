Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int numberB = Convert.ToInt32(Console.ReadLine());
int AtoTheBPower= 1;
while (numberB > 0)
{
    AtoTheBPower= AtoTheBPower * numberA;
    numberB = numberB - 1;
}
Console.WriteLine(AtoTheBPower);