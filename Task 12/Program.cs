using System;

Console.Clear();
Console.Write("Введите первое число: ");
int N1 = int.Parse(Console.ReadLine());  
Console.Write("Введите второе число: ");
int N2 = int.Parse(Console.ReadLine());
if(N1%N2==0) 
{
    Console.Write("-->кратно");
}
else 
{
    Console.Write($"--> не кратно, остаток {N1%N2}");
}