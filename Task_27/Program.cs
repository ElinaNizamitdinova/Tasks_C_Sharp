Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numberSumm= 0;
while (number > 0)
{
    int numberA = number%10;
    numberSumm= numberSumm + numberA;
    number = number/10;
}
Console.WriteLine(numberSumm);