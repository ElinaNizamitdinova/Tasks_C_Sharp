Console.Clear();

Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());



void IntN(int num)
{
    if (num > 0)
    {
        Console.Write($" {num}");
        if (num == 1)
        {
            Console.Write(" ");
        }

        else Console.Write(",");
        IntN(num - 1);
    }
}
Console.Write($"N={numberN} =>");
IntN(numberN);

Console.ReadKey();
