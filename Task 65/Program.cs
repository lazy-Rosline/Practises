//Программа выводит числа в промежутке от M до N.

using System;
using static System.Console;
Clear();

Write("Введите M: ");
int M = int.Parse(ReadLine());
Write("Введите N: ");
int N = int.Parse(ReadLine());
Write(ShowBetween(M, N));

string ShowBetween (int start, int end)
{
    if (start==end) return start.ToString();
    return (start + " " + ShowBetween(start+1, end));
}