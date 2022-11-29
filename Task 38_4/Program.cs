//Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

using System;
Console.Clear();

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(min, max+1);
    }
}

int FindBetween (int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>=min&&array[i]<=max)
        {
            count++;
        }
    }
    return count;
}

int[] Massive = new int[12];
FillArray(Massive, -10, 600);
Console.WriteLine(String.Join(" ", Massive));
Console.WriteLine($"Количество элементов в промежутке от 10 до 99 равно: {FindBetween(Massive, 10, 99)}");