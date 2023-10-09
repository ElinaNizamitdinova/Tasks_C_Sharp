Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
}
else if (firstNumber > secondNumber)
{
Console.WriteLine($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
}
else if(firstNumber==secondNumber)
{
Console.WriteLine($"Введенные числа равны {firstNumber}");
}
