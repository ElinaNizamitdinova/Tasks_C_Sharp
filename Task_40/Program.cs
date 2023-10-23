Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int C = Convert.ToInt32(Console.ReadLine());

bool Triangle(int numberA, int numberB, int numberC)
{

    if (numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberA + numberB)
    {
        return true;
    }
    return false;
}
Console.WriteLine(Triangle(A, B, C));



// Console.Clear();

// System.Console.WriteLine("Введите три числа: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int numberB = Convert.ToInt32(Console.ReadLine());
// int numberC = Convert.ToInt32(Console.ReadLine());

// bool Triangle(int numberA, int numberB, int numberC)
// {

//     if (numberA < numberB + numberC && numberB < numberA + numberC && numberC < numberA + numberB)
//     {
//         return true;
//     }
//     return false;
// }

// System.Console.WriteLine(Triangle(numberA, numberB, numberC));
