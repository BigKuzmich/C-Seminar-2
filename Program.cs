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