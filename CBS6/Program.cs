// task 2
int A, B;
Console.WriteLine("Введите число А:");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
B = Convert.ToInt32(Console.ReadLine());
int x=++A;
Console.WriteLine("Числа между А и В:");
while (x < B)
{
    Console.WriteLine(x);
    x++;

}
x = A;
Console.WriteLine("Нечетные:");
while (x < B)
{
    if ((x&1) == 1)
    {
        Console.WriteLine(x);
    }
    x++;
}