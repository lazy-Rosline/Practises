//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
using System;
using static System.Console;
Clear();
double[] GetArrayDouble(int size)
{
    double[] result=new double[size];
    for(int i=0;i<size;i++)
    {
        result[i]=new Random().Next(-100,100);
   }
    return result;
}
double MaxMinDifference(double[] array)
{
    double max=array[0];
    double min=array[0];
    for (int i=1; i<array.Length;i++)
    {
        if(array[i]>max) max=array[i];
        if(array[i]<min) min=array[i];
    }
    double result = max-min;
    return result;
}
Write("Введите число элементов массива: ");
double[] array=GetArrayDouble(int.Parse(ReadLine()));
WriteLine(String.Join(" ",array));
double Diff=MaxMinDifference(array);
WriteLine(Diff);