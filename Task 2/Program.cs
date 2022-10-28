using System;

Console.Clear();
Console.WriteLine("Введите а: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b: ");
int b = int.Parse(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine($"-->max = {a}");
}
if (a < b) 
{
    Console.WriteLine($"-->max = {b}");
}  