// выводит массив из 8 случайных 0 и 1[]

using System;
using static System.Console;
Clear();

void FillArray(int[] collection)
{
    for (int i=0;i<collection.Length;i++)
    {
        collection[i]=new Random().Next(2);
    }
}

int MaxFromArray (int[] newArray)
{
    int Max=newArray[0];
    int i = 0;
    for(i=1;i<newArray.Length;i++)
    {
        if(newArray[i]>Max) 
        {
            Max=newArray[i];
        }
    }
    return Max;
}


void PrintArray(int[] collection)
{
    for(int i=0;i<collection.Length;i++)
    {
        Write($"{collection[i]} ");
    }
WriteLine();
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
//WriteLine(MaxFromArray(array));
// int maxValue=MaxFromArray(array);
// Write(maxValue);