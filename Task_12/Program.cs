Console.WriteLine("Введите число");
int Anumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чиисло, которому предположительно кратно первое число");
int Bnumber = Convert.ToInt32(Console.ReadLine());
if (Anumber%Bnumber==0){
    Console.WriteLine("Кратно");
}
else{
    int ost=Anumber%Bnumber;
    Console.WriteLine($"Некратно, статок {ost}");
}