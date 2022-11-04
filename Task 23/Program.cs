using System;
using static System.Console;
// Таблица кубов от 1 до N
Clear();
Write("Введите N: ");
int N = int.Parse(Console.ReadLine());  
for(int i=1;i<=N;i++)
{
    Write($"{i*i*i} ");
}