//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;
using static System.Console;

Clear();

int[,] array1 = GetArray(4,5);
PrintArray(array1);
WriteLine();
int[,] array2 = GetArray(3,2);
PrintArray(array2);
WriteLine();
int[,] multiArray= ArrayMultiply(array1, array2);
PrintArray(multiArray);




int[,] GetArray (int row, int column)
{
    int[,] newArray = new int[row, column];
    for(int i=0; i<newArray.GetLength(0); i++)
    {
        for(int j=0; j<newArray.GetLength(1);j++)
        {
            newArray[i, j]=new Random().Next(0, 20);
        }
    }
    return newArray;
}

void PrintArray (int[,] inArr)
{
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1); j++)
        {
            Write($"{inArr[i, j]} ");
        }
        WriteLine();
    }
}

int[,] ArrayMultiply (int[,] arr1, int[,] arr2)
{
    int rows = arr1.GetLength(0);
    if(rows>arr2.GetLength(0)) rows=arr2.GetLength(0);
    int columns = arr1.GetLength(1);
    if(columns>arr2.GetLength(1)) columns=arr2.GetLength(1);
    int[,] res = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            res[i, j]=arr1[i,j]*arr2[i,j];
        }
    }
    return res;
}