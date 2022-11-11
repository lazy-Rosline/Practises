using System;
using static System.Console;

Clear();

int[] ArrayFromString(string user)
{
    string[] nums = user.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

int[] ArrayCopy(int[] InArray)
{
    int[] res = new int[InArray.Length];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = InArray[i];
    }
    return res;
}


Write("Введите набор чисел через пробел: ");
int[] array = ArrayFromString(ReadLine());
int[] arraycopy = ArrayCopy(array);
WriteLine(String.Join((" "), arraycopy));