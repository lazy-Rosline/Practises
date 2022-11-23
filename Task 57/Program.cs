// частотный словарь

using System;
using static System.Console;

Clear();

Write("Задайте исходные элементы (в строку через пробел): ");
int[] numbers = ArrayFromString(ReadLine());
int[,] array = GetArray(5,3,0,10);
PrintBinaryArr(array);
WriteLine();
Search(array, numbers);


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

void Search (int[,] InArray, int[] valuesArray)
{
    int k = 0;
    while (k < valuesArray.Length)
    {
        int count = 0;
        for (int i = 0; i < InArray.GetLength(0); i++)
        {
            for (int j = 0; j < InArray.GetLength(1); j++)
            {
                if(InArray[i,j]==valuesArray[k]) count++;
            }

        }
        WriteLine($"{valuesArray[k]} встречается {count} раз;");
        k++;
    }
    
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

int[] ArrayFromString (string Usr)
{
    string[] str = Usr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[str.Length];
    for (int i = 0; i < res.Length; i++)
    {
        res[i]=int.Parse(str[i]);
    }
return res;
}