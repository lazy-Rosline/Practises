using System;
using static System.Console;

Clear();
Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()); 
// int a = number/1000;
// int b = number%100; 
// if((a/10==b%10)&&(a%10==b/10)) 
if((N/10000==N%10)&&(N/1000%10==N%100/10))
{
    Write("да");
}
else 
{
    Write("нет");
}