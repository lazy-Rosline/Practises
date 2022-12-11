// Напишите программу вычисления функции Аккермана
using System;
using static System.Console;
Clear();

Write("задайте первое число m: ");
int m = int.Parse(ReadLine());
Write("задайте второе число n: ");
int n = int.Parse(ReadLine());
Write($"--> A(m,n)= {Accerman(m, n)}");

int Accerman (int value1, int value2)
{
    if (value1==0) return value2+1;
    else 
    {
        if(value2==0) return Accerman(value1-1, 1);
        else return Accerman(value1-1, Accerman(value1, value2-1));
    }
}