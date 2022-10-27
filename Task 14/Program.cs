using System;

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());  
if(N%7==0&&N%23==0) 
{
    Console.Write("-->да");
}
else 
{
    Console.Write("нет");
}