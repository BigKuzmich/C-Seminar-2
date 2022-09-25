using System;

void Task1()
{
    string str = Console.ReadLine().ToString();
    Console.WriteLine(str[1]);
}

void Task2()
{
    int a = int.Parse(Console.ReadLine());
    if(a > 99)
    {
        string str = a.ToString();
        Console.WriteLine(str[2]);
    }
    else
    {
        Console.WriteLine(" Несодержит третьего числа");
    }
}

void Task3()
{
    int a = int.Parse(Console.ReadLine());
    if(a>0 && a<6)
    {
        Console.WriteLine("Будний день");
    }
    else if(a>5 && a<8)
    {
        Console.WriteLine("Выходной день");
    }
    else if(a>7)
    {
        Console.WriteLine("Такого дня недели не существует ");
    }
}

while (true)
{
    int a= int.Parse(Console.ReadLine());
    if( a == 1)
    {
        Task1();
    }
    if( a == 2)
    {
        Task2();
    }
    if( a == 3)
    {
        Task3();
    }
}