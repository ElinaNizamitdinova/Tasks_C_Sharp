Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
if (value < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int valueSecond = (value / 100) % 10;
    Console.WriteLine(valueSecond);
}