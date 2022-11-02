using System;
using static System.Console;

Clear();

Write("Введите N: ");
int N = int.Parse(ReadLine());
int sum=0;
for (int i=1;i<=N;i++)
{
    sum=sum+i;
}
Write($"сумма от 1 до N = {sum}");