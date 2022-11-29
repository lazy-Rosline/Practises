//Задайте массив из 8 случайных чисел. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
using System;
using static System.Console;

Clear();

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

bool checkNum (int[] InArray, int value)
{
    for (int i = 0; i < InArray.Length; i++)
    {
        if(InArray[i]==value) 
        {
            return true;
        }    
    }   
    return false;
}

int[] workArr = GetArray(8,-10,100);
PrintArray(workArr);
WriteLine("Введите ваше число: ");
int N=int.Parse(ReadLine());
if(checkNum(workArr, N))
{
    WriteLine("да");
}
else WriteLine("нет");
