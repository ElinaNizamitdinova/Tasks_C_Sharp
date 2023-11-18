Console.Clear();

Console.WriteLine("Введите число N");
int numderN = Convert.ToInt32(Console.ReadLine());



void IntN(int num, int current = 1)
{
    if (num < current) return;
    else
    {
        Console.Write(current + " ");
        IntN(num, current + 1);
    }
}

IntN(numderN);

Console.ReadKey();
