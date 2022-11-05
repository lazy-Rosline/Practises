// написать ЦИКЛ, кот возводит А в натур степень В 
using System;
using static System.Console;

Clear();

Write("Введите число А: ");
int A=int.Parse(ReadLine());
Write("Введите число B: ");
int B=int.Parse(ReadLine());

int Degree(int x1, int x2)
{
    int result=1;
    for(int i=1;i<=x2;i++)
    {
      result*=x1;  
    }
    return result;
}

WriteLine($"{A} в {B} = {Degree(A,B)}");