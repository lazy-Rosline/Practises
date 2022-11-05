using System;
using static System.Console;
Clear();
Write("Введите число: ");
Write(Factorial(int.Parse(ReadLine())));

double Factorial (int x)
{   
    double result=1;
    for(int i=1;i<=x;i++)
    {
       result*=i;
    }
    return result;
}



