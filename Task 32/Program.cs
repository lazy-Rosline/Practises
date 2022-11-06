using System;
using static System.Console;

Clear();

int[] ArrayTurnOpposite(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        arr[i]=-arr[i];
    }
    return arr;
}

void Inverse(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Write($"{-array[i]} ");
    }
}

int[] array={1,2,3,4,8,-9,18};
// array= ArrayTurnOpposite(array);
// WriteLine(String.Join(",", array));
Inverse(array);

