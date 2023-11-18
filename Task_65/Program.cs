Console.Clear();



Console.WriteLine("Введите число M");
int numderM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numderN = Convert.ToInt32(Console.ReadLine());

void IntN(int start, int finish)
{
    if (finish >= start)
    {
        Console.Write(start + " ");
        IntN(start + 1, finish);
    }
    else return;
}

IntN(numderM, numderN);

Console.ReadKey();
