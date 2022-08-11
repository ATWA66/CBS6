//task 3
for (int i = 0; i < 5; i++)
{
    if (i == 0 || i == 4)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }
    else
    {
        Console.Write("*");
        for (int j = 0; j < 8; j++)
        {
        Console.Write(" ");
        }
        Console.Write("*\n");
    }
}
//
for (int i = 0; i < 5; i++)
{
    if (i == 0)
    {
        Console.Write("*");
        for (int j = 0; j < 9; j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }
    for (int j = 0; j < 5; j++)
    {
        Console.Write(" ");
        if (i == j || j==4)
        {
            Console.Write("*");
        }
        else
        Console.Write(" ");
    }
    Console.Write("\n");
}
//
for (int i = 0; i < 3; i++)
{
    int j = i;
    while (j < 3)
    { 
    Console.Write("*");
        j++;
    }
    Console.Write("\n");
}
//
int num = 5;
for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        if (i + num / 2 == j || i - num / 2 == j || i == num / 2 - j || i == num / 2 + num - j - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("\n");
}


