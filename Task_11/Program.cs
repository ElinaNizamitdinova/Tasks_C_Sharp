int numder = new Random().Next(100, 1000);
Console.WriteLine(numder);
int first = numder / 100;
int last = numder % 10;

Console.Write(first);
Console.Write(last);
