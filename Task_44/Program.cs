Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int first = 0;
int second = 1;
if (N>=1){
    Console.Write(first);
}
if (N>=2){
    Console.Write(","+second);
}
for (int i = 3; i <= N; i++)
{
    int next = first+second;
    Console.Write(","+next);
    first=second;
    second=next;
}
Console.WriteLine();