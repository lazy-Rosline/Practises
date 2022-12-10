//Программа выводит числа от 1 до N.

using System;
using static System.Console;
Clear();

Write("Введите N: ");
int N = int.Parse(ReadLine());
Write(RecNumber(1, N));

string RecNumber(int initial, int end)
{
    if (initial==end) return initial.ToString();
    return (initial + " " + RecNumber(initial+1, end));
}