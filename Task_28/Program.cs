System.Console.WriteLine("Введите число");
int userA = Convert.ToInt32(Console.ReadLine());

int Mult(int a)
{
    int mult = 1;

    for (int i = 1; i <= a; i++)
    {
        mult= mult*i;
    }
    return mult;
}
int userResult = Mult(userA);
System.Console.WriteLine(userResult);