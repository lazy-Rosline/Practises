// выдаёт сумму цифр в числе
using System;
using static System.Console;

Clear();
Write("Введите число: ");

int SumOfFigures(int SetN)
{
    int count=0;
    while (SetN>0)
    {
        count=count+SetN%10;
        SetN/=10;
    }
    return count;
}

Write(SumOfFigures(int.Parse(Console.ReadLine())));