//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

using System;
using static System.Console;

Clear();

int[,] GetArray (int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
           result [i, j] = new Random().Next(min, max+1); 
        }
    }
    return result;
}

void ElementByNumber (int[,] inArray)
{
    Write("Индекс строки искомого элемента: ");
    int a = int.Parse(ReadLine());
    Write("Индекс столбца искомого элемента: ");
    int b = int.Parse(ReadLine());
    if((a<inArray.GetLength(0))&&(b<inArray.GetLength(1))) 
    {
        Write(inArray[a,b]);
    }
    else Write("такого элемента нет");
}

void PrintArray (int[,] massive)
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

int[,] array = GetArray(5,6,-10,100);
PrintArray(array);
ElementByNumber(array);
