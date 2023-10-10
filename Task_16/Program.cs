Console.WriteLine("Введите число и предпологаемый квадрат числа, порядок не важен");
int numder1 = Convert.ToInt32(Console.ReadLine());
int numder2 = Convert.ToInt32(Console.ReadLine());
if ((numder2 * numder2 == numder1) || (numder2 == numder1 * numder1))
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}