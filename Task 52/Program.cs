//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

Clear();

int[,] array = GetArray(5,3,0,10);
PrintBinaryArr(array);
Write(String.Join("; ", AverageFromNumbersColumn(array)));


int[,] GetArray (int row, int column, int min, int max)
{
    int[,] newArray = new int[row, column];
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column;j++)
        {
            newArray[i, j]=new Random().Next(min, max+1);
        }
    }
    return newArray;
}

void PrintBinaryArr (int[,] massive)
{
    for(int i=0; i<massive.GetLength(0); i++)
    {
        for(int j=0; j<massive.GetLength(1); j++)
        {
            Write($"{massive[i, j]} ");
        }
        WriteLine();
    }
}

double[] AverageFromNumbersColumn (int[,] inArray)
{
    double[] result= new double[inArray.GetLength(1)];
    int m = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {   
        double Sum = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            Sum = Sum+inArray[j,i];
        }
        result[m] = Sum/(inArray.GetLength(0));
        m++;
    }
    return result;
}
