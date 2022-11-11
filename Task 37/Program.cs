// ищет произведение пар чисел в одномерном массиве
using System;
using static System.Console;
Clear();

int[] newArray(int size)
{
    int[] array=new int[size];
    for(int index=0;index<size;index++)
    {
        array[index]=new Random().Next(0, 11);
    }
    WriteLine(String.Join("  ", array));
    int length = size/2;
    if(size%2==1) length++;
    int[] result=new int[length];
    for(int i=0;i<result.Length;i++)
    {
        result[i]=array[i]*array[size-1-i];
    }
    if (size%2==1) result[length-1]=array[size/2];
    return result;
}

WriteLine("Задайте число элементов массива: ");
int N = int.Parse(ReadLine());
int[] Transformed=newArray(N);
WriteLine(String.Join("  ", Transformed));