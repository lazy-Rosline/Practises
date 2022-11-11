// переворачивает одномерный массив:
using System;
using static System.Console;

Clear();

int[] GetArray(int size, int min, int max)
{
    int[] res=new int[size];
    for(int i=0; i<size; i++)
    {
        res[i]= new Random().Next(min, max+1);
    }
    return res;
}

int[] arrayReverse(int[] InArray)
{
    int[] result=new int[InArray.Length];
    for(int k=0; k<result.Length; k++)
    {
        result[k]=InArray[InArray.Length-1-k];
    }
    return result;
}

int[] array1=GetArray(13, 23, 144);
WriteLine(String.Join((" "), array1));
int[] arrayInverse = arrayReverse(array1);
WriteLine(String.Join((" "), arrayInverse));