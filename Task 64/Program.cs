//Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии

using System;
using static System.Console;
Clear();

Write("Введите N: ");
int N = int.Parse(ReadLine());
WriteLine(NumMinus(N));

string NumMinus (int arg)
{
    if(arg==1) return "1";
    else return $"{arg}, " + NumMinus(arg-1);
}