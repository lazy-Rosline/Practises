//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int M = int.Parse(ReadLine());
Write("Введите второе число: ");
int N = int.Parse(ReadLine());
WriteLine(MNSum(M, N));

int MNSum (int m, int n)
{
    if(m==n) return m;
    else return m+MNSum(m+1, n);
}