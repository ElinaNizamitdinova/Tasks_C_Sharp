int Ack(int n, int m)
{

    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Ack(n - 1, 1);
    if (n > 0 && m > 0) return Ack(n - 1, Ack(n, m - 1));
    return Ack(n, m);
}

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int M = Convert.ToInt32(Console.ReadLine());
int ackNM = Ack(N, M);
Console.WriteLine(ackNM);
Console.ReadKey();