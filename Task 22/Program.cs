using System;
using static System.Console;

Clear();
Write("Введите N: ");
int N = int.Parse(Console.ReadLine());  
for(int i=1;i<=N; i++)
{
    Write($"{i*i} ");
}