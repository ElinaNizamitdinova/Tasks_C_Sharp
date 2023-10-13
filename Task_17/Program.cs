


string f(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return "I";
    }
    else if (x < 0 && y < 0)
    {
        return "III";
    }
    else if (x > 0 && y < 0)
    {
        return "IV";
    }
    return "II";
}



Console.WriteLine("Введите значение x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(x, y));