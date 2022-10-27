using System;
Console.Clear();
int N = new Random().Next(100, 1000);

int a1 = N/100;
int a3 = N%10;
Console.WriteLine($"{N}-->{a1}{a3}");
