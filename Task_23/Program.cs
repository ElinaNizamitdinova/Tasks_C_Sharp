Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i<=N){
    Console.WriteLine($"{i}^2 = {Math.Pow(i,3)} ");
    i++;
}
