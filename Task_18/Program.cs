string f(int x)
{
    if (x == 1)
    {
        return "x > 0 && y > 0";
    }
    else if (x == 3)
    {
        return "x < 0 && y < 0";
    }
    else if (x == 4)
    {
        return "x > 0 && y < 0";
    }
    return "x < 0 && y > 0";
}



Console.WriteLine("Введите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(x));