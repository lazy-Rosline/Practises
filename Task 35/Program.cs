using System;
using static System.Console;

Clear();

int[] GetArray(int size, int min, int max)
{
    int[] result=new int[size];
    for(int i=0;i<size;i++)
    {
        result[i]=new Random().Next(min, max+1);
    }
    return result;
}

int[] array=GetArray(123,0,100);
WriteLine(String.Join(", ",array));
int count=0;
for (int i=0;i<array.Length;i++)
{
    if((array[i]>=10)&&(array[i]<=99)) 
    {
        count+=1;
    }
}
Write(count);