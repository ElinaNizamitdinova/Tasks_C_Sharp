Console.WriteLine("Введите число и предпологаемый квадрат числа, порядок не важен");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if ((number2 * number2 == number1) || (number2 == number1 * number1))
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}