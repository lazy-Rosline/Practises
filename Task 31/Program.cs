using System;
using static System.Console;

Clear();

int[] array=new int[12];

void FillArray(int[] collection)
{
    for(int i=0;i<collection.Length;i++)
    {
        collection[i]=new Random().Next(-9,10);
    }
}
void PrintArrayString(int[] collection)
{
    WriteLine($"[{String.Join(",",collection)}]"); 
}
void PrintArray(int[] collection)
{
    for(int i=0;i<collection.Length;i++)
    {
        Write($" {collection[i]}");
    }
}
FillArray(array);
PrintArrayString(array);

int Sum1=0;
int Sum2=0;
for(int count=0;count<array.Length;count++)
{
    if(array[count]<0)
    {
        Sum2+=array[count];
    }
    else 
    {
        Sum1+=array[count];
    }
}
Write($"{Sum2}; {Sum1}");