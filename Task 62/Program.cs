// спиральный массив.
using System;
using static System.Console;
Clear();

void SpiralArray (int[,] Array)
{   int LastValue = 1;
    int i = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i,j]=LastValue;
        LastValue++;
    }
    for (i = 1; i <Array.GetLength(0)-1; i++)
    {
        Array[i, Array.GetLength(1)-1]=LastValue;
        LastValue++;
    }
    i = Array.GetLength(0)-1;
    for (int k = 0; k < Array.GetLength(1); k++)
    {
        Array[i, Array.GetLength(1)-1-k]=LastValue;
        LastValue++;
    }
    i = Array.GetLength(0)-2;
    while(i>0)
    {
        Array[i, 0] = LastValue;
        LastValue++;
        i--;
    }
    i = 1;
    for (int j = 1; j < Array.GetLength(1)-1; j++)
    {
        Array[i, j]= LastValue;
        LastValue++;
    }
    i = 2;
    for (int j = Array.GetLength(1)-2; j > 0; j--)
    {
        Array[i, j]= LastValue;
        LastValue++;
    }
}


void PrintArray (int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            if(Arr[i,j]<10) Write($"0{Arr[i, j]} ");
            else Write($"{Arr[i, j]} ");
        }
        WriteLine();
    }
}

int[,] Array = new int[5,5];
SpiralArray(Array);
PrintArray(Array);

