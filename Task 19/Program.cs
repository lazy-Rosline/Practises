using System;
using static System.Console;

Clear();
Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()); 
int a = number/1000;
int b = number%100; 
if((a/10==b%10)&&(a%10==b/10)) 
{
    Write("да");
}
else 
{
    Write("нет");
}