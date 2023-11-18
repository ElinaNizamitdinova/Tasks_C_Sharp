Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

void SummOfNumbers(int num,int summ=0){
    if (num>0){
    summ= summ+(num%10);
    SummOfNumbers(num/10,summ);
    }
    else Console.WriteLine($"Сумма цифр в числе = {summ}");
    
}
SummOfNumbers(number);
Console.ReadKey();