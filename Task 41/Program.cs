using System;
using static System.Console;

Clear();

int[] ArrayFromString(string user)
{
    string[] nums = user.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToInt32(nums[i]);
    }
    return result;
}

int CountPositive(int[] InArray)
{
    int count=0;
    for (int i=0; i<InArray.Length; i++)
    {
        if (InArray[i]>0) count+=1;
    }
    return count;
}

Write("Введите числа через запятую: ");
int[] x=ArrayFromString(ReadLine());
Write($"количество положительных чисел: {CountPositive(x)}");