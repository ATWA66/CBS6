// task 4
Console.WriteLine("Введите количество клиентов");
int N = Convert.ToInt32(Console.ReadLine());    
int x = 1;
Console.WriteLine(N);

do
{
    x *= N;
    N--;
}
while (N != 1);
Console.WriteLine("количество возможных вариантов:"+x);