using System;

Console.Clear();
Console.Write("Первое число а=: ");
int a = int.Parse(Console.ReadLine());  
Console.Write("Второе число b=: ");
int b = int.Parse(Console.ReadLine());
if(a==b*b) 
{
    Console.Write("a квадрат b");
}
else 
{
    if(b==Math.Pow(a,2)) 
    {
        Console.Write("b квадрат а");
    }
    else 
    {
        Console.Write("не является квадратом");
    }
}