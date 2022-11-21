//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9


using System;
Console.Clear();

int[,] Massive = new int[5,5];
GetArray(Massive, -10, 5);
PrintArray(Massive);
Console.WriteLine();
PrintArray(SortedArray(Massive));


int[,] SortedArray (int[,] numbers)
{
    int[,] result = new int[numbers.GetLength(0), numbers.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = numbers[i,j];
            for (int k = j+1; k < result.GetLength(1); k++)
            {
                if(result[i,j]>numbers[i,k]) 
                {
                    int temp = result[i,j];
                    result[i,j]=numbers[i,k];
                    numbers[i,k]=temp;
                }
            }

        }
        
    }
    return result;
}

void GetArray (int[,] array, int min, int max)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            array[i, j]=new Random().Next(min, max+1);
        }
    }
}

void PrintArray(int[,] array)
{
  for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }  
}