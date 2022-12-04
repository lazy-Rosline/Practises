//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0..
using System;
using static System.Console;

Clear();

double[,] GetArray (int row, int column)
{
    double[,] newArray = new double[row, column];
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column;j++)
        {
            newArray[i, j]= Math.Round((new Random().Next(-10, 11)+ new Random().NextDouble()), 1);
        }
    }
    return newArray;
}

void PrintArray (double[,] massive)
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

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int n = int.Parse(ReadLine());
double[,] array = GetArray(m,n);
PrintArray(array);
