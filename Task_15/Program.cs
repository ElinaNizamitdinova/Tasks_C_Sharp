Console.WriteLine("Введите число");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.Write("Yes");
}
else if (day > 7)
{
    Console.Write("Такого дня недели нет");
}
else
{
    Console.Write("No");
}