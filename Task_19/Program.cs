Console.WriteLine("Введите пятизначное число");
int Numder5 = Convert.ToInt32(Console.ReadLine());
if(Numder5%10==Numder5/10000){
    if ((Numder5/1000)%10==(Numder5/10)%10){
        Console.WriteLine("Число является полиндромом");
    }
}
else
{
    Console.WriteLine("Число не является полиндромом");
}