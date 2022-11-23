//меняет в массиве первую и последн строку местами
using System;
using static System.Console;

Clear();

int[,] Array = new int[4,5];
FillArray(Array, -10, 10);
PrintBinaryArray(Array);
WriteLine();
PrintBinaryArray(SwitchedRow(Array));


int[,] SwitchedRow (int[,] arrIn)
{
    for (int j = 0; j < arrIn.GetLength(1); j++)
    {
        int temp = arrIn[0,j];
        arrIn[0,j]=arrIn[arrIn.GetLength(0)-1,j];
        arrIn[arrIn.GetLength(0)-1,j]=temp;
    }
    return arrIn;
}


void FillArray (int[,] coll, int min, int max)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(min, max + 1);
        }
    }
    WriteLine();
}

void PrintBinaryArray(int[,] massive)
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