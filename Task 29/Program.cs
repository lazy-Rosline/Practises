//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;
using static System.Console;

Clear();

int[] arr = GetArray(8, 0, 20);
// PrintArray(arr);
Write($"[{String.Join(" ", arr)}]");


int[] GetArray (int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
       Write($"{collection[i]} ");
    }
}