//показывает количество чётных чисел в массиве
using System;
using static System.Console;
Clear();

int CountEven(string[] StringArray)
{
    int[] inArray=new int[StringArray.Length];
    int count=0;
    for(int i=0;i<inArray.Length;i++)
    {
        inArray[i]=int.Parse(StringArray[i]);
        if(inArray[i]%2==0) count++;
    }
    return count;
}

Write("Введите набор трехзначных положительных чисел (через пробел) ");
string[] User=ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
int Count=CountEven(User);
Write($"[{String.Join(", ",User)}]-->{Count}");