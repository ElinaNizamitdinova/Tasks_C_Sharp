Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int last = num % 10;
Console.WriteLine($"Последний знак числа {last}");