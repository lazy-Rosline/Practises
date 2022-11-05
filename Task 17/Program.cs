using System;
using static System.Console;

Clear();
Write("Введите координату х: ");
int x = int.Parse(Console.ReadLine());  
Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine()); 
if(x>0&&y>0) 
{
    Write("1 четверть");
}
if(x>0&&y<0) 
{
    Write("4 четверть");
}
if(x<0&&y>0) 
{
    Write("2 четверть");
}
if(x<0&&y<0) 
{
    Write("3 четверть");
}