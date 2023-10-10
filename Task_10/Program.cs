Console.WriteLine("Введите  трехзначное число");
int value =Convert.ToInt32(Console.ReadLine());
int valueSecond =(value / 10)%10;
Console.WriteLine(valueSecond);