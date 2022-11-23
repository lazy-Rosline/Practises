//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;
Clear();
int[,] arr = GetArray(4, 4, 0, 10);
PrintArray(arr);
WriteLine();
int b= MinSum(arr);
Write($"Номер строки с наименьшей суммой элементов: {b}");



int[,] GetArray(int row, int col, int min, int max)
{
    int[,] newArray = new int[row, col];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}
void PrintArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Write($"{massive[i, j]} ");
        }
        WriteLine();
    }
}


int MinSum (int[,] inArray)
{
    int i =0;
    int Sum1 = 0;
    int number = 1;
    for (int j = 0; j <inArray.GetLength(1); j++)
    {
        Sum1=Sum1+inArray[i,j];
    }
    int Min = Sum1;
for (i = 1; i <inArray.GetLength(0); i++)
{
    int Sum2=0;
    for (int k = 0; k < inArray.GetLength(1); k++)
        {
            Sum2=Sum2+inArray[i,k];
        }
    if(Min>Sum2) 
    {Min=Sum2;
    number = i+1;
    }
}
return number;
}
