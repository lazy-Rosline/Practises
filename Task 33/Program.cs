using System;
using static System.Console;

Clear();

int[] ArrayFromString(string stringArray)
{
    string[] cells = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result=new int[cells.Length];
    for(int index=0;index<result.Length;index++)
    {
        result[index]=int.Parse(cells[index]);
    }
    return result;
}

bool ObjectSearch(int[] collection, int value)
{
    for(int i=0;i<collection.Length;i++)
    {
        if(collection[i]==value) return true;
    }
    return false;
}

Write("Введите набор чисел через пробел ");
int[] array=ArrayFromString(ReadLine());
Write("Введите число: ");
int N=int.Parse(ReadLine());
if(ObjectSearch(array, N)) 
{
    Write("да");
}
else 
{
    Write("нет");
}






// int[] GetArray(int size, int min, int max)
// {
//     int[] arr=new int[size];
//     for(int i=0;i<size;i++)
//     {
//         arr[i]=new Random().Next(min,max+1);
//     }
//     return arr;
// }

// int[] array=GetArray(6,-8,108);
// WriteLine($"[{String.Join(", ", array)}]");
// WriteLine("Введите число ");
// int number = int.Parse(ReadLine());
// if(Find(array, number))
// {
//     WriteLine("да");
// }
// else
// {
//     WriteLine("нет");
// }

// bool Find(int[] Array, int x)
// {
//     foreach (int item in Array)
//     {
//         if(item==x) return true;
//     }
//     return false;
// }
