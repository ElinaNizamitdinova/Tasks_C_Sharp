System.Console.WriteLine("Введите число");
int userA = Convert.ToInt32(Console.ReadLine());

(int,int) Summ(int a)
{
    int summ = 0;

    for (int i = 1; i <= a; i++)
    {
        summ = summ + i;
    }
    return (summ, summ);
}
var userResult = Summ(userA);
System.Console.WriteLine(userResult);