int numder = new Random().Next(10, 100);
Console.WriteLine(numder);
int first = numder / 10;
int last = numder % 10;
if (first > last)
{
    Console.Write(first);
}
else
{
    Console.Write(last);
}