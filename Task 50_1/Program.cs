//Напишите программу, которая на вход принимает число, и возвращает индексы 
//числа в двумерном массиве или же указание, что такого элемента нет
using System;
using static System.Console;

Clear();

int[,] Arr = GetArray(5,4,-10,11);
PrintArray(Arr);
WriteLine("Введите число: ");
int Number = int.Parse(ReadLine());
SearchElement( Number, Arr);


int[,] GetArray (int row, int column, int min, int max)
{
    int[,] newArray = new int[row, column];
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column;j++)
        {
            newArray[i, j]= new Random().Next(min, max+1);
        }
    }
    return newArray;
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

void SearchElement (int inValue, int[,] array)
{
    int RowIndex = -1;
    int ColIndex = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j]==inValue)
            {
                RowIndex = i;
                ColIndex = j;
                Write($"({RowIndex}, {ColIndex})");
            }            
        }
    }
    if (RowIndex==-1) Write("такого элемента нет");
}

// void SearchElement (int inValue, int[,] array)
// {
//     int RowIndex = -1;
//     int ColIndex = -1;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i, j]==inValue)
//             {
//                 RowIndex = i;
//                 ColIndex = j;
//             }            
//         }
//         Write($"({RowIndex}, {ColIndex})");
//         break;
//     }
//     if (RowIndex==-1) Write("такого элемента нет");
// }