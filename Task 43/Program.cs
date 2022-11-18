// Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

using System;
using static System.Console;

Clear();

double[] DotCommon (double a, double b, double c, double d)
{
    double[] result={0,0};
    result[0] = (d-c)/(a-b);
    result[1] = a*result[0]+c;
    return result;
}

Write("Введите k1: ");
double k1=int.Parse(ReadLine());
Write("Введите k2: ");
double k2=int.Parse(ReadLine());
Write("Введите b1: ");
double b1=int.Parse(ReadLine());
Write("Введите b2: ");
double b2=int.Parse(ReadLine());
Write(String.Join(";", DotCommon(k1,k2,b1,b2)));

