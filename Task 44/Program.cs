// выводит N чисел Фибоначчи:
using System;
using static System.Console;

Clear();

int[] Fibonacci2(int size)
{
    int[] res = new int[size];
    res[0] = 0;
    res[1] = 1;
    for (int i = 2; i < res.Length; i++)
    {
        res[i] = res[i - 1] + res[i - 2];
    }
    return res;
}

Write("Введите число: ");
WriteLine(String.Join(" ", Fibonacci2(int.Parse(ReadLine()))));